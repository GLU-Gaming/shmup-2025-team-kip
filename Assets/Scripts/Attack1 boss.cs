using UnityEngine;

public class Attack1boss : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed = 15;

    [SerializeField] GameObject Bullet;

    [SerializeField] GameObject BulletSpawn1;
    [SerializeField] GameObject BulletSpawn2;
    [SerializeField] GameObject BulletSpawn3;
    [SerializeField] GameObject BulletSpawn4;
    [SerializeField] GameObject BulletSpawn5;
    [SerializeField] GameObject BulletSpawn6;
    [SerializeField] GameObject BulletSpawn7;
    [SerializeField] GameObject BulletSpawn8;
    // sounds
    [SerializeField] AudioSource Explosion;
    [SerializeField] AudioClip Expl;


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
           
        
        

        if(transform.position.x <= -3f)
        {
            Explosion.Play();
            Destroy(rb);
            
          Instantiate(Bullet, BulletSpawn1.transform.position, BulletSpawn1.transform.rotation);
          Instantiate(Bullet, BulletSpawn2.transform.position, BulletSpawn2.transform.rotation);
          Instantiate(Bullet, BulletSpawn3.transform.position, BulletSpawn3.transform.rotation);
          Instantiate(Bullet, BulletSpawn4.transform.position, BulletSpawn4.transform.rotation);
          Instantiate(Bullet, BulletSpawn5.transform.position, BulletSpawn5.transform.rotation);
          Instantiate(Bullet, BulletSpawn6.transform.position, BulletSpawn6.transform.rotation);
          Instantiate(Bullet, BulletSpawn7.transform.position, BulletSpawn7.transform.rotation);
          Instantiate(Bullet, BulletSpawn8.transform.position, BulletSpawn8.transform.rotation);

            Destroy(gameObject);

        }

    }
}
