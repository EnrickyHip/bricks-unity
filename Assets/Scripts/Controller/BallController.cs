using UnityEngine;

public class BallController : MonoBehaviour
{
    private float playerPixels = 120f;
    private BallModel ballModel;
    private Rigidbody2D myRigidbody;

    void Start()
    {
        this.ballModel = this.GetComponent<BallModel>();
        this.myRigidbody = this.GetComponent<Rigidbody2D>();

        this.Invoke(nameof(SetVelocity), 1);
    }

    private void SetVelocity()
    {
        this.myRigidbody.velocity = this.ballModel.Direction * this.ballModel.Speed;
    }

    public void ChangeAngle(Vector2 direction)
    {
        direction = new Vector2(direction.x, Mathf.Sign(direction.y));
        this.ballModel.Direction = direction.normalized; 
        this.SetVelocity();
    }

    public void PerfectAngleReflection(Collision2D collision)
    {
        Vector2 inDirection = ballModel.Direction;
        Vector2 inNormal = collision.contacts[0].normal;
        Vector2 direction = Vector2.Reflect(inDirection, inNormal);
        this.ChangeAngle(direction);
    }

    public Vector2 CalculateAngleReflection(Collision2D collision)
    {
        //metade do tamanho do player transformado para a escala da unity
        float halfPlayerPixelsUnityScale = this.playerPixels / 2 / 100f;

        float playerToUnityScaleFactor = 1.5f;
        float positionSum = collision.transform.position.x - this.transform.position.x + halfPlayerPixelsUnityScale;
        float unityScaleAngle = positionSum * playerToUnityScaleFactor;

        float angle = unityScaleAngle * 100f;
        float radiusAngle = angle * Mathf.PI / 180f;

        return new Vector2(Mathf.Cos(radiusAngle), Mathf.Sin(radiusAngle)).normalized;
    }
}
