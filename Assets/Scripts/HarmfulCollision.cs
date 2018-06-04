using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HarmfulCollision : MonoBehaviour {
	
	public bool Damage = false;
	public int health = 4;
	public int DamageCost = 1; 
	public GameObject player;
	public GameObject obstacles;
	public Image[] hearts;
	public Sprite FullHeart;

	private Animator lose_heart;
	private Animator anim_pig;
	private Animator anim_thing;
	private bool boom = false;

	// Use this for initialization
	void Start () {
		hearts.Length = health;
		anim_pig = player.GetComponent<Animator> ();
		for (int i = 0; i < hearts.Length; i++) {
			if ( i < health){
				hearts [i].sprite = FullHeart;
			}
		}
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