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

    [SerializeField] float BossHealth = 200;
    void Start()
    {
        
    }

   
    void Update()
    {
        // start timers
        attackTimer += Time.deltaTime;

        // attack 1
        if(attackTimer > 3 && BossHealth >= 150)
        {
            Instantiate(Attack1, Attack1Spawn.transform.position, Attack1SpawnRotate.transform.rotation);
            attackTimer = 0;
        }

        //attack 2
        if(attackTimer > 5 && BossHealth >= 100 && BossHealth <= 150)
        {
            Instantiate(attack2, Attack2Spawn1.transform.position, transform.rotation);
            Instantiate(attack2, Attack2Spawn2.transform.position, transform.rotation);
            Instantiate(attack2, attack2Spawn3.transform.position, transform.rotation);
            Instantiate(attack2, attack2Spawn4.transform.position, transform.rotation);
            attackTimer = 0;
        }
        // attack 3
        if(attackTimer > 5 && BossHealth >=50 && BossHealth <= 100)
        {

        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            BossHealth -= 5;
        }
    }
    
}
