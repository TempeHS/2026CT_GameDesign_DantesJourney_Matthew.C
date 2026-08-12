using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;

    private void Awake() 
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

    public void takeDamage (float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0) 
        {
            anim.SetTrigger("hurt");
        }
        else
        {
            if (!dead)
            {
                anim.SetTrigger("death");
                GetComponent<PlayerMovement>().enabled = false;   
                dead = true;
            }

        }
    }
}
