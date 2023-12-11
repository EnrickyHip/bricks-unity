using System.Collections;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    private BrickModel brickModel;
    private AudioSource audioSource;

    void Start()
    {
        this.brickModel = this.GetComponent<BrickModel>();
        this.audioSource = this.GetComponent<AudioSource>();
        this.audioSource.volume = 1.4f;
    }

    public void TakeDamage()
    {
        this.audioSource.Play();

        this.brickModel.TakeDamage();
        this.brickModel.UpdateColor();

        if (this.brickModel.Lifes <= 0)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            this.Invoke(nameof(DestroyBrick), 0.5f);

            if (GameManager.BricksRemain <= 1)
                GameManager.NextLevel();
        }


    }

    private void DestroyBrick()
    {
        Destroy(gameObject);
    }
}
