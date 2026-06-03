using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void PlayGame() 
    {
        SceneManager.LoadSceneAsync("Limbo");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
