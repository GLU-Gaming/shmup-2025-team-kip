using UnityEngine;

public class PickUp : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] float dropTime;
    PlayerMovement playerMovement;

    bool FastFireRate = false;
    float FireTime;
   
    void Start()
    {
        rb = FindFirstObjectByType<Rigidbody>();
        playerMovement = FindFirstObjectByType<PlayerMovement>();
    }

    
   public void Update()
    {
       if(transform.position.y <= 0)
        {
            Destroy(rb);
        }

      
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           
            Destroy(gameObject);

        }
    }
}
