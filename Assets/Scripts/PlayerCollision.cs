using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Shape")
        {
            Sprite newSprite = other.GetComponent<SpriteRenderer>().sprite;
            spriteRenderer.sprite = newSprite;
        }

        else if (other.tag == "Color")
        {
            Color newColor = other.GetComponent<SpriteRenderer>().color;
            spriteRenderer.color = newColor;
        }
    }
}
