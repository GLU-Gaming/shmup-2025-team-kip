using UnityEngine;

public class ToyBox : MonoBehaviour
{
    [SerializeField] GameObject Toy1;
    [SerializeField] GameObject Toy2;
    [SerializeField] GameObject Toy3;

    public float toychooser;
    public float toyTimer = 0;

    Rigidbody rb;

    float flyLeft = -3;
    float flyright = 3;

    [SerializeField] Vector3 Leftmargin;

    private float toyBoxHealth = 5;
    GameManager game;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        game = FindFirstObjectByType<GameManager>();
    }

    void Update()
    {
       

        toyTimer += Time.deltaTime;

        // spawn in random toy
       if(toyTimer > 0.1)
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
        if (toyTimer > 2 && toychooser == 3)
        {
            Instantiate(Toy3, transform.position, transform.rotation);
            toyTimer = 0;
        }

        // let toybox fly
        if(transform.position.x <= -4.5f) 
        {
            rb.AddRelativeForce(new Vector3(flyright, 0, 0));
        }
        if (transform.position.x >= 6.2f)
        {
            rb.AddRelativeForce(new Vector3(flyLeft, 0, 0));
        }
       // check if toyBox has no health
       if(toyBoxHealth <= 0)
        {
            game.gameScore += 80;
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        // check if toybox hit by bullet
        if (other.CompareTag("Bullet"))
        {
            toyBoxHealth -= 1;
        }
    }
}
