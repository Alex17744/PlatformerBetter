using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Spawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public GameObject EnemyGunPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {

    }
}
