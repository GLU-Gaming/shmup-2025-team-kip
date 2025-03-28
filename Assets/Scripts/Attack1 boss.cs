using UnityEngine;

public class Attack1boss : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed = 3;

    [SerializeField] GameObject Bullet;

    [SerializeField] GameObject BulletSpawn1;
    [SerializeField] GameObject BulletSpawn2;
    [SerializeField] GameObject BulletSpawn3;
    [SerializeField] GameObject BulletSpawn4;
    [SerializeField] GameObject BulletSpawn5;
    [SerializeField] GameObject BulletSpawn6;


    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

   
    void Update()
    {
        
        if (rb != null)
        {
            rb.linearVelocity = transform.forward * speed;
        }
           
        
        

        if(transform.position.x <= -1.4f)
        {
           Destroy(rb);
           
          //Instantiate(Bullet, )
        }

    }
}
