using UnityEngine;
using System.Collections;

public class Walk_test : MonoBehaviour
{
    [SerializeField]
    private float speed;             //Floating point variable to store the player's movement speed.

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    private Vector2 currentVelocity;

    // Use this for initialization
    public float playerSpeed = 4f;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


	private void Update()
	{
        currentVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
	}
	void FixedUpdate()
    {
        rb2d.velocity = currentVelocity * playerSpeed;
    }
}