using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickView : MonoBehaviour
{
    private BrickController brickController;

    void Start()
    {
        this.brickController = this.GetComponent<BrickController>();
    }

    public void TakeDamage()
    {
        this.brickController.TakeDamage();
    }
}
