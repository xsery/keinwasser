using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	private Rigidbody rb;
	private Transform groundCheck;
	private bool onGround;
	private bool facingRight = true;


	private Transform target;
	private bool isDead;
	private float zForce;
	private float WalkTimer;



	public float maxSpeed;
	public float minHeight, maxHeight;


	[SerializeField]
	private float currentSpeed;



	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
		groundCheck = transform.Find ("GroundCheckEnemy");
		target = FindObjectOfType<Player> ().transform;
		currentSpeed = maxSpeed;
		
	}
	
	// Update is called once per frame
	void Update () {

		onGround = Physics.Linecast (transform.position, groundCheck.position, 1 << LayerMask.NameToLayer ("Ground"));

		facingRight = (target.position.x > transform.position.x) ? false : true;
		if (facingRight) {
			transform.eulerAngles = new Vector3 (0, 180, 0);
		} else {
			transform.eulerAngles = new Vector3 (0, 0, 0);

		}

		WalkTimer += Time.deltaTime;
	}

	private void FixedUpdate(){

		if (!isDead) {
			Vector3 targetDistance = target.position - transform.position;
			float hForce = targetDistance.x / Mathf.Abs (targetDistance.x);

			if (WalkTimer >= Random.Range (1f, 2f)) {

				zForce = Random.Range (-1, 2);
				WalkTimer = 0;
			}

			if (Mathf.Abs (targetDistance.x) < 1.5f) {
				hForce = 0;
			}
				
			rb.velocity = new Vector3 (hForce * (currentSpeed * Time.deltaTime), 0, zForce * (currentSpeed * Time.deltaTime));

		}

		rb.position = new Vector3 (rb.position.x, rb.position.y, Mathf.Clamp(rb.position.z, minHeight, maxHeight));
	}

/*	void ResetSpeed(){
		currentSpeed = maxSpeed;
	} */

}
