using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_point : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector2.up * Time.deltaTime *100);
    }
}
