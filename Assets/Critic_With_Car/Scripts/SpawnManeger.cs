using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManeger : MonoBehaviour
{
   public GameObject[] buildingPrefabs;
    private float spawnRangeX = 450;

    private float spawnRangeZ = 450;
    
    
    // Start is called before the first frame update
    void Start()
    {// creating random buildings 
        Invoke("SpawnRandomBuildings", 0);
      
    }

    void SpawnRandomBuildings()
    {
        // Create random animals from our array
         int buildingIndexOne = Random.Range(0, buildingPrefabs.Length);
         int buildingIndexTwo = Random.Range(0, buildingPrefabs.Length);
         int buildingIndexThree = Random.Range(0, buildingPrefabs.Length);


            for (var i = 0; i < 100; i++){
            Vector3 spawnPosTop = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,Random.Range(-spawnRangeX,spawnRangeX));
                
            Instantiate(buildingPrefabs[buildingIndexOne], spawnPosTop, buildingPrefabs[buildingIndexOne].transform.rotation);
            }

            for (var i = 0; i < 50; i++){
            Vector3 spawnPosLeft = new Vector3(Random.Range(-spawnRangeX,spawnRangeX), 0, Random.Range(-spawnRangeZ,spawnRangeZ));
            Instantiate(buildingPrefabs[buildingIndexTwo], spawnPosLeft, Quaternion.Euler(0, 90, 0));
            }
            for (var i = 0; i < 30; i++){
            Vector3 spawnPosRight = new Vector3(Random.Range(-spawnRangeX,spawnRangeX), 0, Random.Range(-spawnRangeZ,spawnRangeZ));
            Instantiate(buildingPrefabs[buildingIndexThree], spawnPosRight, Quaternion.Euler(0, -90, 0));
            }
    }
}
