using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.VFX;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] public int lives = 3;

    [SerializeField] public GameObject life_1;
    [SerializeField] public GameObject life_2;
    [SerializeField] public GameObject life_3;

    public int currentScore;

    [SerializeField] TMP_Text txt;

    public bool gameOver;

    [SerializeField] public int CurrentWave = 1;
    [SerializeField] TMP_Text Wave;

    [SerializeField] public GameObject Car;
    [SerializeField] public float CarTimer;
    [SerializeField] public GameObject CarSPawnLocation;
    void Start ()
    {
        gameOver = false;

    }

    public void Update ()
    {
        CarTimer += Time.deltaTime;
        livesManaging();
        
        txt.text = currentScore.ToString();

        Wave.text = "WAVE :  " + CurrentWave;
        if(CarTimer >= 30)
        {
            SpawnCar();
            CarTimer = 0;
        }
    }

    public void livesManaging ()
    {
        if ( lives == 2 )
        {
            life_3.SetActive( false );
            life_2.SetActive( true );
            life_1.SetActive( true );
        }

        if ( lives == 1 )
        {
            life_3.SetActive ( false );
            life_2.SetActive( false );
            life_1.SetActive ( true );
        }

        if ( lives == 0 )
        {
            life_1.SetActive( false );
            
        }
        

    }
    public void SpawnCar()
    {
        Instantiate(Car, CarSPawnLocation.transform.position, transform.rotation );
    }
}
