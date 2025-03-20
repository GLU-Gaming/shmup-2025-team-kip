using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
     Rigidbody  rb;
    private float verticalSpeed = 1;
    private float horizontalSpeed = 1;

    [SerializeField] GameObject Bullet;
    [SerializeField] GameObject bulletSpawnPoint;
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
           bulletSpawnPoint =  Instantiate(Bullet,transform.position,transform.rotation);
        }
    }
}
