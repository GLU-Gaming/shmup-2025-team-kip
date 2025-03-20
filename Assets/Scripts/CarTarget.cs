using UnityEngine;

public class CarTarget : MonoBehaviour
{
    Rigidbody rb;
    float size = 10;
    float speed = 10;
    public Rigidbody Rb => rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    public void Update()
    {
        var dir = new Vector3(Mathf.Cos(Time.time * speed) * size, Mathf.Sin(Time.time * speed) * size);

        rb.angularVelocity = dir;
    }
}
