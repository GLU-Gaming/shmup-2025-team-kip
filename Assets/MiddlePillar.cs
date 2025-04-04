using UnityEngine;

public class MiddlePillar : MonoBehaviour
{
    public int PillarLives = 2;


    void Start()
    {
        
    }

   
    void Update()
    {
        if(PillarLives <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet") )
        {
            PillarLives -= 1;
        }
    }
}
