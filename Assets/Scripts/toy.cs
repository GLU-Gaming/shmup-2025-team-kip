using UnityEngine;

public class toy : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField ]private float verticalThrowLeft = 7f;
    [SerializeField] private float horizontalThrowLeft = -4f;
    
    [SerializeField] private float verticalThrowRight = -7f;
    [SerializeField] private float horizontalThrowRight = 4f;
    private float ThrowTimer = 0;


    float DeleteTimer;

    public int ThrowSide = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

   
    void Update()
    {
        DeleteTimer += Time.deltaTime;
        if (DeleteTimer > 5)
        {
            Destroy(gameObject);
        }
        ThrowTimer += Time.deltaTime;
        if(ThrowSide == 1)
        {
            if (ThrowTimer < 0.9f)
            {
                rb.linearVelocity = transform.up * verticalThrowLeft;
                rb.linearVelocity = transform.right * -horizontalThrowLeft;
                //rb.AddForce(new Vector3(horizontalThrowLeft, verticalThrowLeft, 0));
            }
        }
        if(ThrowSide == 2)
        {
            if (ThrowTimer < 0.9f)
            {
                rb.AddForce(new Vector3(horizontalThrowRight, verticalThrowRight, 0));
            }
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
