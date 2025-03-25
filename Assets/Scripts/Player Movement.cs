using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
     Rigidbody  rb;
    [SerializeField] private float verticalSpeed;
    [SerializeField] private float horizontalSpeed;

    [SerializeField] GameObject Bullet;
    [SerializeField] GameObject BulletSpawn;
    
  
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        // Player Movement
        verticalSpeed = Input.GetAxisRaw("Vertical");
        rb.AddRelativeForce(new Vector3(0, verticalSpeed, 0 ));

        horizontalSpeed = Input.GetAxisRaw("Horizontal");
        rb.AddRelativeForce(new Vector3(horizontalSpeed, 0, 0));

        // Spawn Bullet
        if (Input.GetKeyDown(KeyCode.Space))
          { 
             Instantiate(Bullet, BulletSpawn.transform.position,transform.rotation);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        // check if Player Hit an enemy
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Hit Enemy");
            Destroy(gameObject);
        }
    }
}
