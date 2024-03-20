using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private float throwForce;
    [SerializeField] private Camera cam;
    [SerializeField] private PropsSpawner propsSpawner;

    public void ThrowBall()
    {
        Vector3 shootDirection = cam.transform.forward;

        // Spawn the ball slightly in front of the AR camera
        Vector3 spawnPosition = cam.transform.position;

        // Instantiate the ball at the spawn position
        GameObject ball = Instantiate(ballPrefab, spawnPosition, Quaternion.identity);

        // Get the Rigidbody component of the spawned ball
        Rigidbody rb = ball.GetComponent<Rigidbody>();

        // Apply force to shoot the ball in the direction the camera is facing
        if (rb != null)
        {
            rb.AddForce(shootDirection * throwForce, ForceMode.Impulse);
        }
        else
        {
            Debug.LogError("Rigidbody component not found on the ball prefab.");
        }
    }
}
