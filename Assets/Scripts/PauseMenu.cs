using UnityEngine;
using UnityEngine.SceneManagement;

public class Paused : MonoBehaviour
{
    [SerializeField] GameObject paused;

    public void Pause()
    {
            paused.SetActive(true);
            Time.timeScale = 0;
            AudioListener.pause = true;
    }

    public void Resume()
    {
            paused.SetActive(false);
            Time.timeScale = 1;
            AudioListener.pause = false;
    }

    public void ReturnMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
        AudioListener.pause = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        AudioListener.pause = false;
    }
}
