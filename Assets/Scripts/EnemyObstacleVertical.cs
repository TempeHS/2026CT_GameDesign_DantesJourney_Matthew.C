using UnityEngine;

public class EnemyObstacleVertical : MonoBehaviour
{
    [SerializeField] private float movementDistance;
    [SerializeField] private float speed;
    [SerializeField] private float damage;
    private bool movingUp;
    private float UpEdge;
    private float DownEdge;

    private void Awake()
    {
        UpEdge = transform.position.y - movementDistance;
        DownEdge = transform.position.y + movementDistance;
    }

    private void Update()
    {
        if (movingUp)
        {
            if (transform.position.y > UpEdge)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
            }
            else
            movingUp = false;
        }

        else
        {
           if (transform.position.y < DownEdge)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
            }
            else
            movingUp = true; 
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.GetComponent<Health>().takeDamage(damage);
        }
    }
}