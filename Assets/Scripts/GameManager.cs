using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.VFX;
using TMPro;
public class GameManager : MonoBehaviour
{
    public int currentScore;

    [SerializeField] TMP_Text txt;

    [SerializeField] public bool gameOver;

    [SerializeField] public int CurrentWave = 1;
    [SerializeField] TMP_Text Wave;

    [SerializeField] public GameObject Car;
    [SerializeField] public float CarTimer;
    [SerializeField] public GameObject CarSPawnLocation;

    SceneSys scenesys;
    void Start ()
    {
        gameOver = false;
        scenesys = FindFirstObjectByType<SceneSys>();
    }

    public void Update ()
    {
        CarTimer += Time.deltaTime;
        
        txt.text = currentScore.ToString();

        Wave.text = "WAVE :  " + CurrentWave;
        if(CarTimer >= 30)
        {
            SpawnCar();
            CarTimer = 0;
        }

        if (gameOver == true)
        {
            Debug.Log( "game overrrr" );
            scenesys.GameOver();
        }
    }

    public void SpawnCar()
    {
        Instantiate(Car, CarSPawnLocation.transform.position, transform.rotation );
    }
}
