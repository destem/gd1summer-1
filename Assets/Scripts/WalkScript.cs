using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkScript : MonoBehaviour {

    // Use this for initialization

    public GameObject player;
    float speed = 5f;
    Animator anim;
	void Start () {

        anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

        movement();

		
	}

    void movement(){
        anim.SetBool("keyDown", false);
        anim.SetBool("goingUp", false);
        anim.SetBool("goingDown", false);
        anim.SetBool("goingLeft", false);
        anim.SetBool("goingRight", false);

        if(Input.anyKey){
            anim.SetBool("keyDown", true);
        }
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d")){
            anim.SetBool("goingRight", true);
            player.transform.Translate(new Vector3(speed*Time.deltaTime, 0, 0));
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
        {
            anim.SetBool("goingLeft", true);
            player.transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
        {
            anim.SetBool("goingUp", true);
            player.transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            anim.SetBool("goingDown", true);
            player.transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }


    }
}
