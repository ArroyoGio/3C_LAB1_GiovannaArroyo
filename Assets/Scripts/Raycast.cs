using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField]public float rayLength = 2f; 
    private Vector2 lastDirection = Vector2.right;

    //en comentarios por favor puede indicarme cual fue mi error con el raycast o IU de unity
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        Vector2 inputDir = new Vector2(moveX, moveY);

        if (inputDir != Vector2.zero)
        {
            lastDirection = inputDir.normalized; 
        }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, lastDirection, rayLength);

        if (hit.collider != null)
        {
            if (hit.collider.CompareTag("Shape"))
            {
                Debug.Log("Raycast está apuntando a un Shape: " + hit.collider.name);
            }
            else if (hit.collider.CompareTag("Color"))
            {
                Debug.Log("Raycast está apuntando a un Color: " + hit.collider.name);
            }
        }

        Debug.DrawRay(transform.position, lastDirection * rayLength, Color.red);
    }
}
