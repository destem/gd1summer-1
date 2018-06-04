using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthManager : MonoBehaviour {


    HarmfulCollision harmfulCollision;
    public GameObject heartGameObject;
    int currentLives;

	// Use this for initialization
    void Start () {
        
        harmfulCollision = GetComponent<HarmfulCollision>();
        currentLives = harmfulCollision.health;
	}
	
	// Update is called once per frame
	void Update () {
        
        if(harmfulCollision.Damage){
        }
	}
}
