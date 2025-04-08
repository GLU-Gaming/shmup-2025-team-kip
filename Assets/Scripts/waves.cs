using System.Collections.Generic;
using UnityEngine;

public class waves : MonoBehaviour
{
    // lists for enemies
    [SerializeField] private List<GameObject> spawnedToyBox = new List<GameObject>();
    [SerializeField] private List<GameObject> spawnedRobot = new List<GameObject>();

    // enemy prefabs
    [SerializeField] GameObject RobotEnemy;
    [SerializeField] GameObject ToyEnemy;
    [SerializeField] GameObject Boss;

    // how many enemies spawn in each round
    float robotCount = 2;
    float ToyBoxCount = 2;

    // spawn points
    [SerializeField] Transform RobotSpawn;
    [SerializeField] Transform ToyBoxSpawn;

    GameManager Game;
    void Start()
    {
        Game = FindFirstObjectByType<GameManager>();
        StartRound();

  
    }

    
    void Update()
    {
        if(spawnedRobot.Count == 0 && spawnedToyBox.Count == 0)
        {
            robotCount += 1;
            ToyBoxCount += 1;
            StartRound();
            Game.CurrentWave += 1;
        }
    }

    public void StartRound()
    {
        if (Game.CurrentWave <=4)
        {
            for (int i = 0; i < robotCount; i++)
            {
                GameObject Robots = Instantiate(RobotEnemy, new Vector3(RobotSpawn.transform.position.x, Random.Range(62f, 132f), 75), Quaternion.identity);
                spawnedRobot.Add(Robots);
            }
            for (int i = 0; i < ToyBoxCount; i++)
            {
                GameObject toyBox = Instantiate(ToyEnemy, new Vector3(Random.Range(73, 120), ToyBoxSpawn.transform.position.y, 75), Quaternion.identity);
                spawnedToyBox.Add(toyBox);
            }
        }
       if(Game.CurrentWave >= 6)
        {
            Instantiate(Boss, new Vector3(63, 0.8f, 75), Quaternion.identity);
        }


    }
    public void RemoveRobot(GameObject RemoveRobot)
    {
        spawnedRobot.Remove(RemoveRobot);
      
    }
    public void RemoveToyBox(GameObject RemoveToyBox)
    {
        spawnedToyBox.Remove(RemoveToyBox);
       
    }
}
