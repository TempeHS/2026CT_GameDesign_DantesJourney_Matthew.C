using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("AUDIO SOURCE")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("AUDIO CLIP")]
    public AudioClip titleScreenMusic;
    public AudioClip limboMusic;
    public AudioClip jumpSFX;
    public AudioClip walkSFX;

    private void Start() 
    {
        musicSource.clip = limboMusic;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
