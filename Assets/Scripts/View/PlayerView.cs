using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private PlayerController playerController;

    void Start()
    {
        this.playerController = this.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        this.playerController.Move(movement);
    }
}
