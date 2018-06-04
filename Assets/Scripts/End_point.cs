using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_point : MonoBehaviour
{
    private Manager m;
    // Use this for initialization
    void Start()
    {
        m = GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector2.up * Time.deltaTime * 100);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (m.score == m.scoreToWin)
            {
                Debug.Log("You win!");
            }
        }
    }
}
