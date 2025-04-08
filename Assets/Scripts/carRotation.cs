
using UnityEngine;

public class carRotation : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] GameObject Car;
    float carRotationSpeed = 5;

    [SerializeField] Transform Cartransform;

    [SerializeField] AudioSource MeepMeep;
    [SerializeField] AudioClip Meep;

    float meeptimer = 0;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    
    void FixedUpdate()
    {
        transform.Rotate(0, 999 * Time.deltaTime, 0, Space.Self);

        meeptimer += Time.deltaTime;

        if(meeptimer > 15)
        {
            MeepMeep.Play();
            meeptimer = 0;
        }
    }


}
