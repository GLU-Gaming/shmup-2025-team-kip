using UnityEngine;

public class BossHand : MonoBehaviour
{
   
    float attackTimer = 0;

    [SerializeField] GameObject Attack1;
    [SerializeField] GameObject Attack1Spawn;
    [SerializeField] GameObject Attack1SpawnRotate;

    float BossHealth = 100;
    void Start()
    {
        
    }

   
    void Update()
    {
        // start timers
        attackTimer += Time.deltaTime;

        if(attackTimer > 5 && BossHealth >= 75)
        {
            Instantiate(Attack1, Attack1Spawn.transform.position, Attack1SpawnRotate.transform.rotation);
            attackTimer = 0;
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
