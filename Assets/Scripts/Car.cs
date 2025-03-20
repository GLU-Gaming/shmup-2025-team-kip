using UnityEngine;
using System;
using System.ComponentModel.Design;

public class Car : MonoBehaviour
{
     Rigidbody rb;


    [SerializeField] float Speed;
    [SerializeField] Vector3 prediction;
    [SerializeField] float RotateSpeed;
    CarTarget target;

    float maxTargetDistance = 100;
    float minTargetDistance = 5;

    float deviationSpeed = 5;
    float deviationAmount = 5;
    private Vector3 standardPrediction, deviatedPrediction;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = FindFirstObjectByType<CarTarget>();
    }

  
    
    private void FixedUpdate()
    {
        
        rb.AddRelativeForce(new Vector3(Speed, 0, 0));

        var leadTimePercentage = Mathf.InverseLerp(minTargetDistance, maxTargetDistance, Vector3.Distance(transform.position, target.transform.position));

        PredictPlayer(leadTimePercentage);

        AddDeviation(leadTimePercentage);

        RotateCar();
    }
    private void RotateCar()
    {
        var Location = prediction - transform.position;

        var rotation =Quaternion.LookRotation(Location);
       rb.MoveRotation(Quaternion.RotateTowards(transform.rotation, rotation, RotateSpeed * Time.deltaTime));
      
    }
    private void PredictPlayer(float leadTimePercentage)
    {
        var predictionTime = Mathf.Lerp(0, minTargetDistance, leadTimePercentage);

        standardPrediction = target.Rb.position + target.Rb.angularVelocity * predictionTime;


    }

    private void AddDeviation(float leadTimePercentage)
    {
        var deviation = new Vector3(Mathf.Cos(Time.time * deviationSpeed), 0, 0);

        var predictionOffset = transform.TransformDirection(deviation) * deviationAmount * leadTimePercentage;

        deviatedPrediction = standardPrediction + predictionOffset;
    }
   
}
