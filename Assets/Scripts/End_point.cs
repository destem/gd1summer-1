using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End_point : MonoBehaviour
{
    private Manager manager;
    public Text Win;
    // Use this for initialization
    void Start()
    {
        Win.text = "";
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
            if (Manager.Instance.score == Manager.Instance.scoreToWin)
            {
                Destroy(gameObject);
                Win.text = "You Win!";
                Debug.Log("You win!");
            }
        }
    }
}
