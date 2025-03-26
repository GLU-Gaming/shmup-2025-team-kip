using UnityEngine;

public class DropShip : MonoBehaviour
{
    Rigidbody rb;

    // start timer
    [SerializeField] float startTimer = 0;

    [SerializeField] float speed;

    // pickup
    [SerializeField] GameObject Pickup;
    [SerializeField] GameObject PickUpSpawnPoint;
    float PickUpTimer = 30;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 0;
    }

  
    void Update()
    {
        // start Timers
        startTimer += Time.deltaTime;
        PickUpTimer += Time.deltaTime;

        // check if Timer is 60 seconds
        if(startTimer > 60)
        {
            speed = -5;
            rb.AddForce(new Vector3(1 * speed, 0, 0));
           
        }
        // check if ship is in the middle of the screen
        if(transform.position.x <= -2 && transform.position.x >= -3 && PickUpTimer >= 30)
        {
            Instantiate(Pickup, PickUpSpawnPoint.transform.position, transform.rotation);
            PickUpTimer = 0;
        }
        // reset ship to start
        if(transform.position.x <= -20)
        {
            transform.position = new Vector3(14f, transform.position.y, transform.position.z);
            startTimer = 0;
            speed = 0;
        }

            
    }
}
