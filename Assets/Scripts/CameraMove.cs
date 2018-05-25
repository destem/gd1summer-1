using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
    public GameObject player;
    Camera m; //main camera
    //Camera moves if player gets halfway off screen, screen is 10x18, assumes 3x3 grid of tiles, 
    //so camera won't move position past +/- 10 on x or +/- 18 on y


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//checking x pos first
        if(m.transform.position.x < 10 && player.transform.position.x % 5 == 0 && player.transform.position.x % 10 != 0 && player.transform.position.x > m.transform.position.x) // moving up to next screen
        {
            float t = 0; //for lerping movement
            Vector2 final_pos = 

        }
        else if (m.transform.position.x > -10 && player.transform.position.x % 5 == 0 && player.transform.position.x % 10 != 0 && player.transform.position.x < m.transform.position.x) //moving down to next screen
        {

        }
        else if (m.transform.position.y < 18 && player.transform.position.y % 9 == 0 && player.transform.position.y % 18 != 0 && player.transform.position.y > m.transform.position.y)// moving right to next screen
        {

        }
        else if (m.transform.position.y > -18 && player.transform.position.y % 9 == 0 && player.transform.position.y % 18 != 0 && player.transform.position.y < m.transform.position.y) // moving left to next screen
        {

        }

    }
}
