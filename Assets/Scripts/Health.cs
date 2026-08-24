using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;
    private Rigidbody2D rb;
    

    private void Awake() 
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
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
                rb.linearVelocity = Vector2.zero;
                rb.angularVelocity = 0f;
                rb.Sleep();
                dead = true;
            }

        }
    }

    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }
}
