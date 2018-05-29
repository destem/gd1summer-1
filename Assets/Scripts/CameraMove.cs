using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;
    public Camera m; //main camera
                     //Camera moves if player gets halfway off screen, screen is 10x18, assumes 3x3 grid of tiles, 
                     //so camera won't move position past +/- 10 on x or +/- 18 on y


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //checking y pos first
        float t = 10;
        if (player.transform.position.y >= 0)
        {
            if (m.transform.position.y < 7.5 && player.transform.position.y > m.transform.position.y && player.transform.position.y % 5 >= 4.9) // moving up
            {

                Vector3 ini_pos = new Vector3(m.transform.position.x, m.transform.position.y, -1.0f); // starting position of camera
                Vector3 final_pos = new Vector3(m.transform.position.x, m.transform.position.y + 7.5f, -1.0f);// ending position of camera
                m.transform.position = Vector3.Lerp(ini_pos, final_pos, t); // Lerp and move camera
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z); // move player out of buffer zone

            }
            else if (player.transform.position.y < m.transform.position.y && player.transform.position.y % 5 <= 0.2) //moving down to next screen
            {

                Vector3 ini_pos = new Vector3(m.transform.position.x, m.transform.position.y, -1.0f); // starting position of camera
                Vector3 final_pos = new Vector3(m.transform.position.x, m.transform.position.y - 7.5f, -1.0f);// ending position of camera
                m.transform.position = Vector3.Lerp(ini_pos, final_pos, t);// Lerp and move camera
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - 1, player.transform.position.z);// move player out of buffer zone
            }
        }
        else if (player.transform.position.y < 0)
        {
            if (player.transform.position.y > m.transform.position.y && player.transform.position.y % 5 >= -0.2) // moving up to next screen
            {

                Vector3 ini_pos = new Vector3(m.transform.position.x, m.transform.position.y, -1.0f); // starting position of camera
                Vector3 final_pos = new Vector3(m.transform.position.x, m.transform.position.y + 7.5f, -1.0f);// ending position of camera
                m.transform.position = Vector3.Lerp(ini_pos, final_pos, t);// Lerp and move camera
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z);// move player out of buffer zone

            }
            else if (m.transform.position.y > -7.5f && player.transform.position.y < m.transform.position.y && player.transform.position.y % 5 <= -4.9) //moving down to next screen
            {

                Vector3 ini_pos = new Vector3(m.transform.position.x, m.transform.position.y, -1.0f); // starting position of camera
                Vector3 final_pos = new Vector3(m.transform.position.x, m.transform.position.y - 7.5f, -1.0f);// ending position of camera
                m.transform.position = Vector3.Lerp(ini_pos, final_pos, t);// Lerp and move camera
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - 1, player.transform.position.z);// move player out of buffer zone
            }
        }
        if (player.transform.position.x >= 0)
        {
            if (m.transform.position.x < 16 && player.transform.position.x % 8 >= 7.9 && player.transform.position.x > m.transform.position.x)// moving right to next screen
            {
                Vector3 ini_pos = new Vector3(m.transform.position.x, m.transform.position.y, -1.0f); // starting position of camera
                Vector3 final_pos = new Vector3(m.transform.position.x + 16, m.transform.position.y, -1.0f);// ending position of camera
                m.transform.position = Vector3.Lerp(ini_pos, final_pos, t); // Lerp and move camera
                player.transform.position = new Vector3(player.transform.position.x + 1, player.transform.position.y, player.transform.position.z); // move player out of buffer zone
            }
            else if (m.transform.position.x > -16 && player.transform.position.x % 8 <= 0.2 && player.transform.position.x < m.transform.position.x) // moving left to next screen
            {
                Vector3 ini_pos = new Vector3(m.transform.position.x, m.transform.position.y, -1.0f); // starting position of camera
                Vector3 final_pos = new Vector3(m.transform.position.x - 16, m.transform.position.y, -1.0f);// ending position of camera
                m.transform.position = Vector3.Lerp(ini_pos, final_pos, t);// Lerp and move camera
                player.transform.position = new Vector3(player.transform.position.x - 1, player.transform.position.y, player.transform.position.z);// move player out of buffer zone
            }
        }
        else if (player.transform.position.x < 0)
        {
            if (player.transform.position.x > m.transform.position.x && player.transform.position.x % 8 >= -0.2) // moving up to next screen
            {

                Vector3 ini_pos = new Vector3(m.transform.position.x, m.transform.position.y, -1.0f); // starting position of camera
                Vector3 final_pos = new Vector3(m.transform.position.x + 16, m.transform.position.y, -1.0f);// ending position of camera
                m.transform.position = Vector3.Lerp(ini_pos, final_pos, t);// Lerp and move camera
                player.transform.position = new Vector3(player.transform.position.x + 1, player.transform.position.y, player.transform.position.z);// move player out of buffer zone

            }
            else if (m.transform.position.x > -16 && player.transform.position.x < m.transform.position.x && player.transform.position.x % 8 <= -7.9) //moving down to next screen
            {

                Vector3 ini_pos = new Vector3(m.transform.position.x, m.transform.position.y, -1.0f); // starting position of camera
                Vector3 final_pos = new Vector3(m.transform.position.x - 16, m.transform.position.y, -1.0f);// ending position of camera
                m.transform.position = Vector3.Lerp(ini_pos, final_pos, t);// Lerp and move camera
                player.transform.position = new Vector3(player.transform.position.x - 1, player.transform.position.y, player.transform.position.z);// move player out of buffer zone
            }
        }

    }
}