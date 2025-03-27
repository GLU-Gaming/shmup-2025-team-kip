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

    // how many enemies spawn in each round
    float robotCount = 2;
    float ToyBoxCount = 2;

    // spawn points
    [SerializeField] Transform RobotSpawn;
    [SerializeField] Transform ToyBoxSpawn;
    void Start()
    {
        StartRound();
    }

    
    void Update()
    {
        if(spawnedRobot.Count == 0 && spawnedToyBox.Count == 0)
        {
            robotCount += 1;
            ToyBoxCount += 1;
            StartRound();
        }
    }

    private void StartRound()
    {
        for(int i = 0; i < robotCount; i++)
        {
            GameObject Robots = Instantiate(RobotEnemy, RobotSpawn.transform.position, transform.rotation);
            spawnedRobot.Add(Robots);
        }
        for(int i = 0;i < ToyBoxCount; i++)
        {
            GameObject toyBox = Instantiate(ToyEnemy, ToyBoxSpawn.transform.position, transform.rotation);
            spawnedToyBox.Add(toyBox);
        }


    }
}
