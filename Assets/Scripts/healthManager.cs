using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthManager : MonoBehaviour {


    HarmfulCollision harmfulCollision;
    public GameObject player;
    int currentLives;
    bool animationPlaying;

	// Use this for initialization
    void Start () {
        animationPlaying = false;
        print("initialize");
        harmfulCollision = player.GetComponent<HarmfulCollision>();
        currentLives = harmfulCollision.health;

	}
	
	// Update is called once per frame
	void Update () {

        //if(animationPlaying){
        //    Animator animator = gameObject.transform.GetChild(currentLives).GetComponent<Animator>();
        //    if (animator.GetCurrentAnimatorStateInfo(0).IsName("heartBreakAnim"))
        //    {
        //        print("done");
        //        animator.SetBool("takeDamage", false);
        //        gameObject.transform.GetChild(currentLives).gameObject.SetActive(false);
        //    } 
        //}

	}
    public void loseLife(){
        animationPlaying = true;
        print("lose life");
        currentLives--;
        Animator animator = gameObject.transform.GetChild(currentLives).GetComponent<Animator>();
        animator.SetBool("takeDamage", true);
        Destroy (gameObject.transform.GetChild(currentLives).gameObject, 0.58f); 


    }
}
