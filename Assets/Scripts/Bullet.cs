using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float bulletForce;

    // Bullet delete timer
    float bulletDeleteTimer;
    bool bulletTimerStart;
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        // start Bullet delete timer
       bulletTimerStart = true;

    }

    
    void Update()
    {
        // let bullet go forward
        rb.AddRelativeForce(new Vector3(bulletForce, 0, 0));

        // Delete the bullet in 3 seconds
        if (bulletTimerStart)
        {
            bulletDeleteTimer += Time.deltaTime;
        }
        if(bulletDeleteTimer >= 3)
        {
            Destroy(gameObject);
        }
    }

     void OnTriggerEnter(Collider other)
    {
      // check if enemy is hit and delete bullet
      if(other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Debug.Log("Enemy hit");
        }
    }
}
