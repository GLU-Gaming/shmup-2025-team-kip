using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.VFX;
public class GameManager : MonoBehaviour
{


    [SerializeField] public int lives = 3;

    [SerializeField] public GameObject life_1;
    [SerializeField] public GameObject life_2;
    [SerializeField] public GameObject life_3;

    // all enemies
    //[SerializeField] public GameObject carEnemy; //homing missile enemy
    //[SerializeField] public GameObject toyboxEnemy; // shoots different items in a curve
    //[SerializeField] public GameObject robotEnemy; // only shoots forward

    [SerializeField] public int currentWave = 1;


    [SerializeField] private List<GameObject> enemiesOnScreen = new();
    private bool waveActive = true;


    void Start ()
    {

    }

    void Update ()
    {
        if ( currentWave == 1 && waveActive == true )
        {
            
        }
    }

    void SpawnWave ( int difficulty )
    {
        waveActive = true;

    }

}
