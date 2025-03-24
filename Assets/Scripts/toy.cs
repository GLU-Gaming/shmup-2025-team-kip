using UnityEngine;

public class toy : MonoBehaviour
{
    Rigidbody rb;

    private float verticalSpeed = 3;
    private float horizontalSpeed = 1;
    private float ThrowTimer = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

   
    void Update()
    {
        ThrowTimer += Time.deltaTime;
        if(ThrowTimer < 2)
        {
            rb.AddRelativeForce(new Vector3(horizontalSpeed, verticalSpeed, 0));
        }
    }
}
