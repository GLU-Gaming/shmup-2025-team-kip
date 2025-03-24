using UnityEngine;

public class HomingMissile : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    public float rotateSpeed = .03f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
    }
    private void OnTriggerEnter(Collider other)
    {
        // check if rocket hit player
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
