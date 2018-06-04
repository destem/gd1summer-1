using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_point : MonoBehaviour
{
    private Manager manager;
    // Use this for initialization
    void Start()
    {
        //m = GetComponent<Manager>();
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
            Debug.Log(Manager.Instance.score);
            Debug.Log(Manager.Instance.scoreToWin);
            if (Manager.Instance.score == Manager.Instance.scoreToWin)
            {
                Destroy(gameObject);
                Debug.Log("You win!");
            }
        }
    }
}
