using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 300f;

    private float horizontalInput;
    private float verticalInput;
    private float mouseInput;

    void Update()
    {
        // Get input from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Get input from mouse
        mouseInput = Input.GetAxis("Mouse X");

        // Move the player
        transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime);

        // Rotate the player
        transform.Rotate(Vector3.up, mouseInput * turnSpeed * Time.deltaTime);
    }
}
