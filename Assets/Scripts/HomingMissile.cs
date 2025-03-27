using UnityEngine;

public class HomingMissile : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    public float rotateSpeed = .03f;

    private Rigidbody rb;

    private float carHealth = 3;

    GameManager game;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        game = FindFirstObjectByType<GameManager>();
    }

    private void LateUpdate()
    {
        Vector3 direction = target.position - rb.position;
        direction.Normalize();
        // rotate rocket to player
        Vector3 amountToRotate = Vector3.Cross(direction, transform.forward) * Vector3.Angle(transform.forward, direction);

        // let car fly forward
        rb.angularVelocity = -amountToRotate * rotateSpeed;

        rb.linearVelocity = transform.forward * speed;
        //Delete car if no health
        if (carHealth <= 0)
        {
            game.gameScore += 100;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        // check if rocket hit player
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        // check if car got hit by bullet
        if (other.CompareTag("Bullet"))
        {
            carHealth -= 1;
        }
        
    }
}
