using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Car : MonoBehaviour
{
     Rigidbody rb;


    [SerializeField] float Speed;
    [SerializeField] Vector3 prediction;
    [SerializeField] float RotateSpeed;
    [SerializeField] 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

  
    void Update()
    {
        RotateCar();
        var leadTimePercentage = Mathf.InverseLerp(Vector3.Distance(transform.position, target.transform.position));
    }
    private void FixedUpdate()
    {
        
        rb.AddRelativeForce(new Vector3(Speed, 0, 0));

    }
    private void RotateCar()
    {
        var Location = prediction - transform.position;

        var rotation =Quaternion.LookRotation(Location);
        rb.MoveRotation(Quaternion.RotateTowards(transform.rotation, rotation, RotateSpeed * Time.deltaTime));
    }
}
