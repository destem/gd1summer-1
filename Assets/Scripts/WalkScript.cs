using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkScript : MonoBehaviour {

    // Use this for initialization
    [SerializeField]
    private float playerSpeed= 5f;             //Floating point variable to store the player's movement speed.

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    private Vector2 currentVelocity;
    public GameObject player;
    Animator anim;

    private HarmfulCollision harmfulCollision;

	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        harmfulCollision = GetComponent<HarmfulCollision>();

	}
	
	// Update is called once per frame
	void Update () {

        movement();
        if(harmfulCollision.Damage){
            print("damage");
            anim.SetBool("touchEnemy", true);

        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("hurtAnim")){
            anim.SetBool("touchEnemy", false);
        }
        if(anim.GetBool("touchEnemy")){
            print("yep");
        }


		
	}

    void movement(){


        anim.SetBool("isIdle", false);
        anim.SetBool("isMoving", true);

        currentVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        anim.SetFloat("moveX", currentVelocity.x);
        anim.SetFloat("moveY", currentVelocity.y);

        if(currentVelocity== Vector2.zero){
            anim.SetBool("isMoving", false);
            anim.SetBool("isIdle", true);
        }
            
        

    }
    void FixedUpdate()
    {
        rb2d.velocity = currentVelocity * playerSpeed;
    }
}


