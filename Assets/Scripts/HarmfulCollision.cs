using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HarmfulCollision : MonoBehaviour {
	
	public bool Damage = false;
	public int health = 4;
	public int DamageCost = 1; 
	public GameObject player;
    public GameObject healthManagergm;

	private Animator lose_heart;
	private Animator anim_pig;
	private Animator anim_thing;
	private bool boom = false;

	// Use this for initialization
	void Start () {
		anim_pig = player.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Damage) {
			health -= DamageCost;
			Damage = false;
            if (health == 0)
            {
                SceneManager.LoadScene("main");
            }
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
            healthManagergm.GetComponent<healthManager>().loseLife();
            GetComponent<Animator>().SetBool("touchEnemy", true);
			Damage = true;
			boom = true;
			anim_thing = other.GetComponent<Animator> ();
			anim_thing.SetBool ("Boom", boom);
			anim_pig.SetBool ("Damage", Damage);
			other.gameObject.SetActive (false);
			boom = false;
            
		}
	}

	void LoseHeart(){
	}
}