using UnityEngine;

public class FramerateUnlocker : MonoBehaviour
{
    private void Start()
    {
        Application.targetFrameRate = 144;
    }
}
