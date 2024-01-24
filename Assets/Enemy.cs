using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;

    public float moveSpeed = 2.0f;
    public float rotationSpeed = 10.0f;

    void Update()
    {
        // Rotate towards the player
        Vector3 direction = (player.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);

        // Move towards the player
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check for collision with a bullet
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // Destroy the enemy
            Destroy(gameObject);
        }
    }
}


