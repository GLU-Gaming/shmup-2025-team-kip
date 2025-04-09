using UnityEngine;

public class Bossattack3 : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed = 50;

    float DeleteTimer = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = transform.right * -speed;
    }

   
    void Update()
    {
         

        
       

        DeleteTimer += Time.deltaTime;
        if(DeleteTimer > 15)
        {
            Destroy(gameObject);
        }
    }
}
