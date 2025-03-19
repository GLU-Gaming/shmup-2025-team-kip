using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float bulletForce;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = transform.forward * bulletForce;
    }

    
    void Update()
    {
        rb.AddRelativeForce(new Vector3(bulletForce, 0, 0));
    }
}
