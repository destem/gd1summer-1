using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkScript : MonoBehaviour {

    // Use this for initialization

    public GameObject player;
    float speed = 5f;
	void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {

        movement();

		
	}

    void movement(){
        if(Input.GetKey(KeyCode.RightArrow)){
            player.transform.Translate(new Vector3(speed*Time.deltaTime, 0, 0));
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            player.transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            player.transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }

    }
}
