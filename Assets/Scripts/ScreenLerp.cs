using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class ScreenLerp : MonoBehaviour
{
    [SerializeField] private Vector3 startPosition = new Vector3( 0, 0, 102 ); // start and end positie van de 2 bg plaatjes, zijn in unity zelf aangepast met serialize
    [SerializeField] private Vector3 endPosition = new Vector3( 209, 0, 102 );
    [SerializeField] private float duration = 3f; // hoelang ze erover doen in seconden, om naar rechts te gaan
    private float elapsedTime; // hoeveel tijd al is verlopen

    

    void Start ()
    {
        startPosition = transform.position;
    }

    void Update ()
    {
        elapsedTime += Time.deltaTime; // checkt hoe lang hij al bezig is met deltatime
        float percentageComplete = elapsedTime / duration;

        transform.position = Vector3.Lerp( startPosition, endPosition, percentageComplete );

    }
}
    

