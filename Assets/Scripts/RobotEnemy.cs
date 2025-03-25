using UnityEngine;

public class RobotEnemy : MonoBehaviour
{
    private float FireRate = 0;

    [SerializeField] GameObject Bullet;
    void Start()
    {
        
    }

    void Update()
    {
        FireRate += Time.deltaTime;

        if(FireRate > 1)
        {
          Instantiate(Bullet, transform.position, transform.rotation);
        }
    }
}
