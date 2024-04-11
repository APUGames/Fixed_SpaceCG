using UnityEngine;
using UnityEngine.SceneManagement;



public class HomeMenuController : MonoBehaviour
{
    public void LoadFirstLevel()
    {
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
