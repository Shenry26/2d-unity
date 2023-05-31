using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float maxDistance = 5f;

    private bool movingUp = true;
    private float initialY;
    private float currentDistance = 0f;

    private void Start()
    {
        initialY = transform.position.y;
    }

    private void Update()
    {
        if (movingUp)
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
            currentDistance += moveSpeed * Time.deltaTime;

            if (currentDistance >= maxDistance)
            {
                movingUp = false;
            }
        }
        else
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
            currentDistance -= moveSpeed * Time.deltaTime;

            if (currentDistance <= -maxDistance)
            {
                movingUp = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Change direction when colliding with any collider
        movingUp = !movingUp;
    }
}

