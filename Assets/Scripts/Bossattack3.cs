using UnityEngine;

public class Bossattack3 : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed = 4;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        rb.linearVelocity = transform.right * -speed;
    }
}
