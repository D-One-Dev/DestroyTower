using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private float throwForce;
    [SerializeField] private Camera cam;
    [SerializeField] private int ballCount;
    [SerializeField] private TMP_Text ballCountText;
    [SerializeField] private Button throwButton;
    private void Start()
    {
        UpdateBallCount();
    }
    public void ThrowBall()
    {
        ballCount--;
        if (ballCount >= 0)
        {
            Vector3 shootDirection = cam.transform.forward;
            // Spawn the ball slightly in front of the AR camera
            Vector3 spawnPosition = cam.transform.position;
            // Instantiate the ball at the spawn position
            GameObject ball = Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
            // Get the Rigidbody component of the spawned ball
            Rigidbody rb = ball.GetComponent<Rigidbody>();
            // Apply force to shoot the ball in the direction the camera is facing
            rb.AddForce(shootDirection * throwForce, ForceMode.Impulse);
            UpdateBallCount();
            if(ballCount == 0) throwButton.interactable = false;
            else throwButton.interactable = true;
        }
    }

    private void UpdateBallCount()
    {
        ballCountText.text = "Balls left: " + ballCount;
    }
}
