using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{   
    public static GameManager instance;
    public GameObject[] buildingPrefabs;
    private float spawnRangeX = 450;

    private float spawnRangeZ = 450;
     int score = 0;
     int highscore = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI gameOwerText;
    public GameObject restartButton;
    
    public float timeValue = 60;
    public bool gameOver = false;

    private void Awake() {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
       Invoke("SpawnRandomArt", 0);
       scoreText.text = "Score: " + score.ToString();
       restartButton.SetActive(false);
       
      //  UpdateScore(0);
    }

    public void AddPoints()
    {
        score += 66;
        scoreText.text = "Score: " + score.ToString();
    }

    void DispleyTime(float timeToDisplay)
    {
        if(timeToDisplay < 10)
        {
            timerText.color = Color.red;
        }

        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
            gameOwerText.text = "You did everything you could!";
            gameOver = true;
            restartButton.SetActive(true);
            
        }

        float seconds = Mathf.FloorToInt(timeToDisplay);

        timerText.text = seconds.ToString();
    }

    void Update()
    {
        if(timeValue > 0)
        {
         timeValue -= Time.deltaTime;
        }
        else {
            timeValue = 0;
        } 

        DispleyTime(timeValue);
    }
  

    // public void UpdateScore(int scoreToAdd)
    //  {
    //      score += scoreToAdd;
    //      scoreText.text = "Score: " + score; 
    // }

    void SpawnRandomArt()
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
