using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallModel : MonoBehaviour
{
    private Vector2 defaultDirection = new(0.7071071f, 0.7071071f);

    [SerializeField] private float speed;
    private Vector2 direction = Vector2.down;

    public float Speed { get => this.speed; } 
    public Vector2 DefaultDirection { get => this.defaultDirection; } 
    public Vector2 Direction
    { 
        get => this.direction;
        set => this.direction = value; 
    } 
}
