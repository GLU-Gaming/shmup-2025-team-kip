using UnityEngine;

public class RobotEnemy : MonoBehaviour
{
    private float FireRate = 0;

    [SerializeField] GameObject Bullet;

    [SerializeField] GameObject BulletSpawn;

    Rigidbody rb;

    // fly speed
    [SerializeField] float flyDown = -5;
    [SerializeField] float flyUp = 5;

    float robotHp = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        FireRate += Time.deltaTime;

        if(FireRate > 1.5f)
        {
          Instantiate(Bullet, transform.position, transform.rotation);
            FireRate = 0;
        }

        if(transform.position.y >= 26f)
        {
            rb.AddRelativeForce(new Vector3(0, flyDown, 0));
        }
        if(transform.position.y <= -27f)
        {
            rb.AddRelativeForce(new Vector3(0, flyUp, 0));
        }
        if(robotHp <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            robotHp -= 1;
        }
    }

}
