using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthManager : MonoBehaviour {


    HarmfulCollision harmfulCollision;
    public GameObject player;
    int currentLives;

	// Use this for initialization
    void Start () {
        print("initialize");
        harmfulCollision = player.GetComponent<HarmfulCollision>();
        currentLives = harmfulCollision.health;
	}
	
	// Update is called once per frame
	void Update () {
        
        if(harmfulCollision.Damage){
            
            print("deactivate");

        }
	}
    public void loseLife(){
        currentLives--;
        gameObject.transform.GetChild(currentLives).gameObject.SetActive(false);
    }
}
