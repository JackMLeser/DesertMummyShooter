using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiate the bullet at the bullet spawn's position and rotation
        Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        
        // Add additional shooting logic here, like recoil, sound, etc.
    }
}
