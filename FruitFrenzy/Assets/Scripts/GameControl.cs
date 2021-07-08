using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        SetText();
    }

    void SetText()
    {
        // setting value to text field 
        // ToString() converts the number into a set of characters which text field can use
        scoreText.text = score.ToString();
    }

    public void AddPoints(int points)
    {
        // Tally the points 
        score = score + points;
        SetText();
    }

    public void GameOver()
    {
        // save score 
        // PlayerPrefs is used to carry the value of something between scenes
        PlayerPrefs.SetInt("userScore", score);
        // go to game over screen
        SceneManager.LoadScene("loseScene");
    }

    // Update is called once per frame
    /*void Update()
    {
        
    } */
}
