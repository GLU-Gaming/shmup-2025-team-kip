using UnityEngine;

public class ToyBox : MonoBehaviour
{
    [SerializeField] GameObject Toy1;
    [SerializeField] GameObject Toy2;
    [SerializeField] GameObject Toy3;

    public float toychooser;
    public float toyTimer = 0;
    void Start()
    {
        
    }

    
    void Update()
    {
        toyTimer += Time.deltaTime;

       if(toyTimer > 1)
        {
            toychooser = Random.Range(0, 4);
        }
        if (toyTimer > 2  && toychooser == 1)
        {
            Instantiate(Toy1, transform.position, transform.rotation);
            toyTimer = 0;
        }
        if( toyTimer > 2 && toychooser == 2)
        {
             Instantiate(Toy2, transform.position, transform.rotation);
            toyTimer = 0;
        }
        if (toyTimer > 2 && toychooser == 2)
        {
            Instantiate(Toy3, transform.position, transform.rotation);
            toyTimer = 0;
        }
    }

}
