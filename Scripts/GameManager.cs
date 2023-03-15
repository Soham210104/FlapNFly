using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
  
    public Text scoreText;//for storing scores
    public GameObject gameOver;
    public GameObject reload;
    public GameObject menu;
    public GameObject stopScript;
   
   
    int score;
    // Start is called before the first frame update

    void Awake()
    {
        gameOver.SetActive(false);
        reload.SetActive(false);
        menu.SetActive(false);
        

    }
    
   
    public void  GameOver()
    {
        gameOver.SetActive(true);
        reload.SetActive(true);
        menu.SetActive(true);
        Time.timeScale = 0;
        

    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();//converting our integer to string.
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
