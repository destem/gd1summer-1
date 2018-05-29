using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarmfulCollision : MonoBehaviour {
	
	public bool Damage = false;
	public int health;
	public int DamageCost; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Damage) {
			health -= DamageCost;
			Damage = false;
		}	
	}

	/*private void OnCollisionEnter2D (Collision2D other) {
		print ("111111");
		if (other.gameObject.tag == "Harmful") {
			print ("111111");
			Damage = true;
		}
	}*/

	private void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Harmful") {
			Damage = true;
			other.gameObject.SetActive (false);
		}
	}
}