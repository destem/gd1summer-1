using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkScript : MonoBehaviour {

    // Use this for initialization

    public GameObject player;
    float speed = 5f;
    public Animator anim;
    bool goingUp= false;
    bool goingRight = false;
    bool keyDown= false;
	void Start () {

        anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

        movement();

		
	}

    void movement(){
        
        anim.SetBool("keyDown", true);
        anim.SetBool("goingUp", false);
        anim.SetBool("goingDown", false);
        anim.SetBool("goingLeft", false);
        anim.SetBool("goingRight", false);
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d")){
            player.transform.Translate(new Vector3(speed*Time.deltaTime, 0, 0));
            anim.SetBool("goingRight", true);

        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
        {
            player.transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            anim.SetBool("goingLeft", true);
        }
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
        {
            player.transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
            anim.SetBool("goingUp", true);
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            player.transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
            anim.SetBool("goingDown", true);
        }
        else{
            anim.SetBool("keyDown", false);
        }

    }
}
