using UnityEngine;

public class BossHand : MonoBehaviour
{
   
    float attackTimer = 0;

    [SerializeField] GameObject Attack1;
    [SerializeField] GameObject Attack1Spawn;
    [SerializeField] GameObject Attack1SpawnRotate;


    [SerializeField] GameObject attack2;
    [SerializeField] GameObject Attack2Spawn1;
    [SerializeField] GameObject Attack2Spawn2;
    [SerializeField] GameObject attack2Spawn3;
    [SerializeField] GameObject attack2Spawn4;

    [SerializeField] GameObject attack3;

    [SerializeField] public float BossHealth = 300;

    [SerializeField] int speed;
    // attack3 Variabelen
    [SerializeField] bool Attack3Going = false;

    float Attack3Timer= 0;

    [SerializeField] GameObject Attack3Spawn1;
    [SerializeField] GameObject Attack3Spawn2;
    [SerializeField] GameObject Attack3Spawn3;
    [SerializeField] GameObject Attack3Spawn4;

    bool Attack3one = true;
    bool Attack3two = true;
    bool Attack3three = true;
    bool Attack3four = true;
    float bossFlySpeed = 3;
    bool BossInMiddle = true;

    bool BossGoingUp = false;
    bool BossGoingDown = false;

    // attack 4 variabelen
    public GameObject Attack4;

    int RandomXSpawn;

    //[SerializeField] Vector3 BossAttack4Spawn;

    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        RandomXSpawn = Random.Range(5, 11);
    }

   
    void Update()
    {
        // start timers
        attackTimer += Time.deltaTime;
        if (Attack3Going == true)
        {
            Attack3Timer += Time.deltaTime;
        }
       

        // attack 1
        if(attackTimer > 4 && BossHealth >= 225)
        {
            Instantiate(Attack1, Attack1Spawn.transform.position, Attack1SpawnRotate.transform.localRotation);
            attackTimer = 0;
        }

        //attack 2
        if(attackTimer > 7 && BossHealth >= 150 && BossHealth <= 225)
        {
            Instantiate(attack2, Attack2Spawn1.transform.position, transform.rotation);
            Instantiate(attack2, Attack2Spawn2.transform.position, transform.rotation);
            Instantiate(attack2, attack2Spawn3.transform.position, transform.rotation);
           // Instantiate(attack2, attack2Spawn4.transform.position, transform.rotation);
            attackTimer = 0;

        }
        // attack 3
        {
            if (attackTimer > 5 && BossHealth >= 75 && BossHealth <= 150)
            {
                Attack3Going = true;

                attackTimer = 0;

            }
            if (Attack3Timer >= 0 && Attack3one && Attack3Timer <= 1)
            {
                Instantiate(attack3, Attack3Spawn1.transform.position, transform.rotation);
                Attack3one = false;
            }
            if (Attack3Timer >= 2 && Attack3two && Attack3Timer <= 3)
            {
                Instantiate(attack3, Attack3Spawn2.transform.position, transform.rotation);
                Attack3two = false;
                Attack3one = true;
            }
            if (Attack3Timer >= 4 && Attack3three && Attack3Timer <= 5)
            {
                Instantiate(attack3, Attack3Spawn3.transform.position, transform.rotation);
                Attack3three = false;
                Attack3two = true;
            }
            if (Attack3Timer >= 6 && Attack3four && Attack3Timer <= 7)
            {
                Instantiate(attack3, Attack3Spawn4.transform.position, transform.rotation);
                Attack3four = false;
                Attack3Timer = 0;
                Attack3Going = false;
                Attack3three = true;
                Attack3four = true;
            }
            if(BossHealth >= 75 && BossHealth <= 150)
            {
                if(BossInMiddle == true)
                {
                    rb.linearVelocity = transform.up * bossFlySpeed;
                }
                if(transform.position.y > 3.5)
                {
                 
                    BossInMiddle = false;
                    BossGoingDown = true;
                    BossGoingUp = false;
                }
                if (transform.position.y < -1.5)
                {
                    
                    BossGoingUp = true;
                    BossGoingDown = false;
                }
                if(BossGoingUp == true)
                {
                    rb.linearVelocity = transform.up * bossFlySpeed;

                }
                if(BossGoingDown == true)
                {
                    rb.linearVelocity = transform.up * -bossFlySpeed;
                }
            }

        }

        // attack4 
        if(attackTimer >= 3.5f && BossHealth >= 0 && BossHealth <= 75)
        {
            Instantiate(Attack4, new Vector3(12,RandomXSpawn,75),  transform.rotation);
            attackTimer = 0;
            RandomXSpawn = Random.Range(-13, 10);
        }
    }

   
    
}
