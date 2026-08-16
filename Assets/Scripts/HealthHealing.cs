using UnityEngine;

public class HealthHealing : MonoBehaviour
{
    [SerializeField] private float healthValue;

    private void onTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().AddHealth(healthValue);
            gameObject.SetActive(false);
        }
    }
}
