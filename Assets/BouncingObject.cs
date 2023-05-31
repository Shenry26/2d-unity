using UnityEngine;

public class BouncingObject : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 direction;

    private void Start()
    {
        // Start the object moving in a random direction
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }

    private void Update()
    {
        // Move the object
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Bounce off the collision point
        ContactPoint2D contact = collision.GetContact(0);
        Vector2 reflectDirection = Vector2.Reflect(direction, contact.normal);
        direction = reflectDirection.normalized;
    }
}
