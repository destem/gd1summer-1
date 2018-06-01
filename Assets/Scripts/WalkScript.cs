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
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

        movement();

		
	}

    void movement(){


        anim.SetBool("keyDown", false);
        anim.SetBool("goingUp", false);
        anim.SetBool("goingDown", false);
        anim.SetBool("goingLeft", false);
        anim.SetBool("goingRight", false);
        currentVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if(Input.anyKey){
            anim.SetBool("keyDown", true);
        }
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d")){
            anim.SetBool("goingRight", true);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
        {
            anim.SetBool("goingLeft", true);
        }
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
        {
            anim.SetBool("goingUp", true);
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            anim.SetBool("goingDown", true);
        }


    }
    void FixedUpdate()
    {
        rb2d.velocity = currentVelocity * playerSpeed;
    }
}


