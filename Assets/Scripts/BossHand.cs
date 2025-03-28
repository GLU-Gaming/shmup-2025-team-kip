using UnityEngine;

public class BossHand : MonoBehaviour
{
   
    float attackTimer = 0;

    [SerializeField] GameObject Attack1;
    [SerializeField] GameObject Attack1Spawn;
    [SerializeField] GameObject Attack1SpawnRotate;
    void Start()
    {
        
    }

   
    void Update()
    {
        // start timers
        attackTimer += Time.deltaTime;

        if(attackTimer > 10)
        {
            Instantiate(Attack1, Attack1Spawn.transform.position, Attack1SpawnRotate.transform.rotation);
            attackTimer = 0;
        }
    }

}
