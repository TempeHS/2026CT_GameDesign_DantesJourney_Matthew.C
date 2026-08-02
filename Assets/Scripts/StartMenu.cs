using UnityEngine;
using UnityEngine.SceneManagement;



public class StartMenu : MonoBehaviour
{

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void Start() 
    {
        audioManager.PlaySFX(audioManager.titleScreenMusic);
    }

    public void PlayGame() 
    {
        SceneManager.LoadSceneAsync("Limbo");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
