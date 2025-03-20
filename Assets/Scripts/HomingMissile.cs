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

        Vector3 amountToRotate = Vector3.Cross(direction, transform.forward) * Vector3.Angle(transform.forward, direction);

        rb.angularVelocity = -amountToRotate * rotateSpeed;

        rb.linearVelocity = transform.forward * speed;
    }
}
