using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    public int score;
    public int scoreToWin;
    public Text scoreText;
	public Text WinText;
	public Button Again;

    //creates the Manager Instance, which is required for increasing the score
    private static Manager instance = null;
    public static Manager Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }

        instance = this;
        //DontDestroyOnLoad(this.gameObject);
    }

    // Use this for initialization
    void Start()
    {
        scoreText.text = "score is 0 / 8";
        score = 0;
        scoreToWin = 9;
        SetScoreText();
		WinText.enabled = false;
		Again.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
		if (score == scoreToWin) {
			WinText.enabled = true;
			Again.enabled = true;
		}
    }

    public void AddScore()
    {

        GameObject.FindWithTag("Player").GetComponent<Animator>().SetBool("isEating", true);
        score++;
        //print("score increase");
        SetScoreText();

        /*if (score >= scoreToWin)
        {
            print("win");
        }*/
    }

	void SetScoreText()
    {
        scoreText.text = "score is " + score.ToString()+ " / 9";
    }

	public void Replay(){
		SceneManager.LoadScene ("main");
	}
}
