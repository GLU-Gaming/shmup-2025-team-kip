
using UnityEngine;

public class carRotation : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] GameObject Car;
    float carRotationSpeed = 5;

    [SerializeField] Transform Cartransform;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        transform.Rotate(0, 999 * Time.deltaTime, 0, Space.Self);
    }
}
