using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int lifes;
    [SerializeField] private Vector2 direction;

    public float Speed { get => this.speed; }
}
