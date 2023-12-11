using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallView : MonoBehaviour
{
    private BallController ballController;
    private Renderer myRenderer;
    void Start()
    {
        this.ballController = GetComponent<BallController>();
        this.myRenderer = GetComponent<Renderer>();
    }

    private void Die()
    {
        GameManager.Replay();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector2 direction = this.ballController.CalculateAngleReflection(collision);
            this.ballController.ChangeAngle(direction);
        }

        if (collision.gameObject.CompareTag("Brick"))
        {
            this.ballController.PerfectAngleReflection(collision);
            BrickView brickView = collision.gameObject.GetComponent<BrickView>();
            brickView.TakeDamage();
        }
            
        if (collision.gameObject.CompareTag("Wall"))
            this.ballController.PerfectAngleReflection(collision);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
            this.Invoke(nameof(Die), 0.2f);
    }
}
