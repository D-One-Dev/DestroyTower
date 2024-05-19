using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public void LoadLevel(int level)
    {
        SceneManager.LoadScene("Level_" + level);
    }
}
