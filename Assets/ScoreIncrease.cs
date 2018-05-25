using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreIncrease : MonoBehaviour { 

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //destroys collectible and increases score when player collides
    private void OnCollisionEnter2D(Collision2D col)
    {
        print("collided");
        if (col.gameObject.tag == "Player")
        {
            Manager.Instance.AddScore();
            Destroy(gameObject);
        }
    }
}