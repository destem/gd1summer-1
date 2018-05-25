using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    public int score;
    public int scoreToWin;
    public Text scoreText;

    //creates the Manager Instance, which is required for increasing the score
    private static Manager instance = null;
    public static Manager Instance
    {
        get
        {
            return instance;
        }
    }

    // Use this for initialization
    void Start () {
        score = 0;
        scoreToWin = 1;
        //SetScoreText();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddScore()
    {

        score++;
        print("score increase");
        //SetScoreText();

        /*if (score >= scoreToWin)
        {
            print("win");
        }*/
    }

    void SetScoreText()
    {
        scoreText.text = "score is " + score.ToString();
    }
}
