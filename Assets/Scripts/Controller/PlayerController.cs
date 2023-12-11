using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerModel playerModel;
    private Rigidbody2D myRigidbody;

    void Start()
    {
        this.playerModel = this.GetComponent<PlayerModel>();
        this.myRigidbody = this.GetComponent<Rigidbody2D>();
    }
     
    public void Move(float movement)
    {
        this.myRigidbody.velocity = new Vector2(movement * this.playerModel.Speed, 0f);
    }
}
