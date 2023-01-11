using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{   
    public static GameManager instance;
  
     int score = 0;
    // int highscore = 0;
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
      
       scoreText.text = "Score: " + score.ToString();
       restartButton.SetActive(false);
       
      
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
        //exit game by press Esc button
          if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
  

   

}
