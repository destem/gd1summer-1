using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
    public GameObject player;
    public Camera m; //main camera
    //Camera moves if player gets halfway off screen, screen is 10x18, assumes 3x3 grid of tiles, 
    //so camera won't move position past +/- 10 on x or +/- 18 on y


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //checking y pos first
        Debug.Log(player.transform.position +  " " + player.transform.position.y % 10 +" " + m.transform.position + " "+ m.transform.position.y);
        Debug.Log(m.transform.position.y < 10);
        Debug.Log(player.transform.position.y > m.transform.position.y);
        Debug.Log(player.transform.position.y % 10 < -1);
        Debug.Log("---------");
        if (player.transform.position.x >= 0) {
            if (m.transform.position.y < 15 && player.transform.position.y > m.transform.position.y && player.transform.position.y % 10 >= 9) // moving up
            {
                float t = 10; //for lerping movement
                Vector3 ini_pos = new Vector3(m.transform.position.x, m.transform.position.y, -1.0f); // starting position of camera
                Vector3 final_pos = new Vector3(m.transform.position.x, m.transform.position.y + 15, -1.0f);// ending position of camera
                m.transform.position = Vector3.Lerp(ini_pos, final_pos, t); // Lerp and move camera
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z); // move player out of buffer zone

            }
            else if (m.transform.position.y < -15 && player.transform.position.y < m.transform.position.y && player.transform.position.y % 10 <= 1 || player.transform.position.y % 10 <= -9) //moving down to next screen
            {
                float t = 10; //for lerping movement
                Vector3 ini_pos = new Vector3(m.transform.position.x, m.transform.position.y, -1.0f); // starting position of camera
                Vector3 final_pos = new Vector3(m.transform.position.x, m.transform.position.y - 15, -1.0f);// ending position of camera
                m.transform.position = Vector3.Lerp(ini_pos, final_pos, t);// Lerp and move camera
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - 1, player.transform.position.z);// move player out of buffer zone
            }
        }
        else if (player.transform.position.x < 0)
        {
            if (m.transform.position.y < 15 && player.transform.position.y < m.transform.position.y && player.transform.position.y % 10 <= -1) // moving up to next screen
            {
                Debug.Log("Should go up");
                float t = 10; //for lerping movement
                Vector3 ini_pos = new Vector3(m.transform.position.x, m.transform.position.y, -1.0f); // starting position of camera
                Vector3 final_pos = new Vector3(m.transform.position.x, m.transform.position.y + 15, -1.0f);// ending position of camera
                m.transform.position = Vector3.Lerp(ini_pos, final_pos, t);// Lerp and move camera
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z);// move player out of buffer zone

            }
            else if (m.transform.position.y > -15 && player.transform.position.y > m.transform.position.y && player.transform.position.y % 10 >= -9) //moving down to next screen
            {
                float t = 10; //for lerping movement
                Vector3 ini_pos = new Vector3(m.transform.position.x, m.transform.position.y, -1.0f); // starting position of camera
                Vector3 final_pos = new Vector3(m.transform.position.x, m.transform.position.y - 15, -1.0f);// ending position of camera
                m.transform.position = Vector3.Lerp(ini_pos, final_pos, t);// Lerp and move camera
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - 1, player.transform.position.z);// move player out of buffer zone
            }
        }
        else if (player.transform.position.y >= 0) { 
           if (m.transform.position.x < 18 && player.transform.position.x % 18 == 0 && player.transform.position.x > m.transform.position.x)// moving right to next screen
            {

            }
            else if (m.transform.position.x > -18 && player.transform.position.x % 18 == 0 && player.transform.position.x < m.transform.position.x) // moving left to next screen
            {

            }
        }
        else if (player.transform.position.y < 0)
        {

        }

    }
}
