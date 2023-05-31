using UnityEngine;

public class SwitchingVerticalMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float switchInterval = 2f;

    private float currentTimer = 0f;
    private int moveDirection = 1;

    private void Update()
    {
        // Calculate the movement vector
        Vector2 movement = new Vector2(0f, moveDirection * moveSpeed * Time.deltaTime);

        // Move the object
        transform.Translate(movement);

        // Update the timer
        currentTimer += Time.deltaTime;

        // Check if it's time to switch direction
        if (currentTimer >= switchInterval)
        {
            // Switch the direction
            moveDirection *= -1;

            // Reset the timer
            currentTimer = 0f;
        }
    }
}
