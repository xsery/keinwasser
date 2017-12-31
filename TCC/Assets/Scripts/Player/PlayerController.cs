using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rbPlayer;
	private Animator anim;
	private Transform groundCheck;

	private bool onGround;
	private float horizontal;
	private float vertical;
	private float jump;

	public float horizontalForce;
	public float verticalForce;
	public float jumpForce;

	// Use this for initialization
	void Start () {

		rbPlayer = GetComponent<Rigidbody> ();
		groundCheck = gameObject.transform.Find ("GroundCheck");

	}
	
	// Update is called once per frame
	void Update () {

		onGround = Physics.Linecast (transform.position, groundCheck.position, 1 << LayerMask.NameToLayer ("Ground"));

	}


	void FixedUpdate () {
		
		horizontal = Input.GetAxis ("Horizontal");
		vertical = Input.GetAxis ("Vertical");
		jump = Input.GetAxis ("Jump"); 


		rbPlayer.velocity = new Vector3(horizontal * Time.deltaTime * horizontalForce, rbPlayer.velocity.y, vertical * Time.deltaTime * verticalForce);

		if (onGround == true) {
			onGround = false;
			rbPlayer.AddForce (new Vector2(0 ,jump * jumpForce));
		}



	}
}
