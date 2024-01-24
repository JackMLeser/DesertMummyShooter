using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadFirstScene()
    {
        // Assuming your first scene is at index 0
        SceneManager.LoadScene(0);
    }
}
