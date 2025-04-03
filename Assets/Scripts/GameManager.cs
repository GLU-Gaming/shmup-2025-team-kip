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
    void Start ()
    {
        gameOver = false;

    }

    void Update ()
    {
        livesManaging();
        
        txt.text = currentScore.ToString();

        Wave.text = "WAVE :  " + CurrentWave;
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

    }
}
