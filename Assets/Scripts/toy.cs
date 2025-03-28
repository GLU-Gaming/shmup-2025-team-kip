using UnityEngine;

public class toy : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField ]private float verticalThrow = 3.5f;
    [SerializeField] private float horizontalThrow = -1.1f;
    private float ThrowTimer = 0;


    float DeleteTimer;

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
        if(ThrowTimer < 1.3f)
        {
            rb.AddRelativeForce(new Vector3(horizontalThrow, verticalThrow, 0));
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
