using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float steerSpeed = 3f;
    public float speedIncreaseRate = 0.1f;
    private bool isCaught = false;

    void Update()
    {
        if (isCaught) return;

        // Forward movement
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Steering (Input System)
        float steer = 0f;
        if (Keyboard.current != null)
        {
            if (Keyboard.current.leftArrowKey.isPressed) steer -= 1f;
            if (Keyboard.current.rightArrowKey.isPressed) steer += 1f;
        }
        transform.Translate(Vector3.right * steer * steerSpeed * Time.deltaTime);

        // Speed up over time
        speed += speedIncreaseRate * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            isCaught = true;
            // Show caught message or trigger cutscene
            Debug.Log("Caught by teacher!");
        }
    }
}
