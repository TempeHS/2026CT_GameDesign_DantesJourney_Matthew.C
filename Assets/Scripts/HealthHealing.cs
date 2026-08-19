using UnityEngine;

public class HealthHealing : MonoBehaviour
{
    [SerializeField] private float healthValue;

        AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().AddHealth(healthValue);
            audioManager.PlaySFX(audioManager.healSFX);
            gameObject.SetActive(false);
        }
    }
}
