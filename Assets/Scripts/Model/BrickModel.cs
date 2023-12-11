using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickModel : MonoBehaviour
{
    [SerializeField] private int lifes;
    private SpriteRenderer spriteRenderer;

    public int Lifes { get => lifes; }

    public void Start()
    {
        this.spriteRenderer = this.GetComponent<SpriteRenderer>();
        this.UpdateColor();
    }

    public void UpdateColor()
    {
        this.spriteRenderer.color = this.GetColor();
    }

    private Color GetColor()
    {
        switch (this.lifes)
        {
            case 1:
                return new Color(0.2f, 0.8f, 0f);
            case 2:
                return new Color(0.7f, 0.8f, 0f);
            case 3:
                return new Color(0.8f, 0.6f, 0f);
            case 4:
                return new Color(0.8f, 0.3f, 0f);
            default:
                return new Color(0.8f, 0.1f, 0f);
        }
    }

    public void TakeDamage()
    {
        this.lifes -= 1;
    }
}
