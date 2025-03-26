using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
     Rigidbody  rb;
     private float verticalSpeed = 3;
     private float horizontalSpeed = 1;

    [SerializeField] GameObject Bullet;
    [SerializeField] GameObject BulletSpawn;

    [SerializeField] float speedamount;

    protected GameManager gamemanager;
    PickUp pickup;
    // firerate
    [SerializeField] public float FireRate;
    bool FastShoot = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gamemanager = FindAnyObjectByType<GameManager>();
        pickup = FindAnyObjectByType<PickUp>();
    }

   
    void Update()
    {
        // Start timers
        FireRate += Time.deltaTime;
        // Player Movement
        verticalSpeed = Input.GetAxisRaw("Vertical");
        rb.AddRelativeForce(new Vector3(0, verticalSpeed * speedamount, 0 ));

        horizontalSpeed = Input.GetAxisRaw("Horizontal");
        rb.AddRelativeForce(new Vector3(horizontalSpeed * speedamount, 0, 0));

        // Spawn Bullet
        if (Input.GetKeyDown(KeyCode.Space) && FireRate >= 0.5f)
          { 
             Instantiate(Bullet, BulletSpawn.transform.position,transform.rotation);
           if(FastShoot == false)
            {
                FireRate = 0;
            }

        }
        if(FireRate >= 15)
        {
            FastShoot = false;
        }
       
    }
    public void OnTriggerEnter(Collider other)
    {
        // check if Player Hit an enemy
        if (other.gameObject.CompareTag("Enemy"))
        {
            gamemanager.lives -= 1;

        }
        if (other.gameObject.CompareTag("PickUp"))
        {
            FastFireRatePlayer();
        }
    }
    public void FastFireRatePlayer()
    {
        FastShoot = true;   
    }
}
