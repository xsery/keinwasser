using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	//player
	private Transform target;


	//enemy
	private Rigidbody rb;
	private Animator anim;
	private Transform groundCheckEnemy;
	private bool onGround;
	private bool facingRight = true;
	//verifica se ta vivo
	private bool isDead = false;
	//verifica a distancia no eixo z
	private float zForce;
	//contador para variar movimentacao
	private float WalkTimer;
	//velocidade atual do inimigo
	private float currentSpeed;
	//verifica se ta recebendo dano
	private bool damaged = false;
	//verifica tempo de dano
	private float damageTimer;
	//tempo para atacar novamente
	private float nextAttack;

	//velocidade maxima do inimigo
	public float maxSpeed;
	//Posicao minima e maxima no eixo Z
	public float minHeight, maxHeight;
	//total de vida do inimigo
	public int maxHealth;
	//tempo recebendo dano
	public float damageTime = 0.5f;
	//vida atual inimigo
	public int currentHealth;

	public float attackRate = 1f;









	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
		anim = GetComponent<Animator> ();
		groundCheckEnemy = transform.Find ("GroundCheckEnemy");
		target = FindObjectOfType<Player> ().transform;
		currentSpeed = maxSpeed;
		currentHealth = maxHealth;
		
	}
	
	// Update is called once per frame
	void Update () {

		//verifica se esta no chao
		onGround = Physics.Linecast (transform.position, groundCheckEnemy.position, 1 << LayerMask.NameToLayer ("Ground"));

		//rotaciona o enemy de acordo com o inimigo
		facingRight = (target.position.x > transform.position.x) ? false : true;
		if (facingRight) {
			transform.eulerAngles = new Vector3 (0, 180, 0);
		} else {
			transform.eulerAngles = new Vector3 (0, 0, 0);

		}


		if (damaged && !isDead) {
			damageTimer += Time.deltaTime;
			if (damageTimer >= damageTime) {

				damaged = false;
				damageTimer = 0;

			}
		}



		//cronometro para variar direcao do enemy
		WalkTimer += Time.deltaTime;
	}

	private void FixedUpdate(){

		if (!isDead) {
			//verifica a distancia do enemy pro player
			Vector3 targetDistance = target.position - transform.position;

			//hForce = -1 se player esquerda ou +1 se player direita
			float hForce = targetDistance.x / Mathf.Abs (targetDistance.x);



			//varia contador para mudar de direcao
			if (WalkTimer >= Random.Range (1f, 2f)) {

				zForce = Random.Range (-1, 2);
				WalkTimer = 0;
			}


			//para variacao de direcao se tiver perto do inimigo
			if (Mathf.Abs (targetDistance.x) < 1.5f) {
				hForce = 0;
			}


			//movimenta o inimigo se nao tiver levando dano
			if(!damaged){
				
				rb.velocity = new Vector3 (hForce * currentSpeed, 0, zForce * currentSpeed);
				//anim.SetBool ("Walk", true);
			}

			if (Mathf.Abs (targetDistance.x) < 1.5f && Mathf.Abs (targetDistance.z) < 1.5f && Time.time > nextAttack) {
				currentSpeed = 0;
				nextAttack = Time.time + attackRate;
			}

		}

		rb.position = new Vector3 (rb.position.x, rb.position.y, Mathf.Clamp(rb.position.z, minHeight, maxHeight));
	}


	//funcao para verificar dano
	public void TookDamage(int damage){

		if (!isDead) {
			damaged = true;
			currentHealth -= damage;
			if (currentHealth <= 0) {
				isDead = true;
				rb.AddRelativeForce (new Vector3(3,5,0), ForceMode.Impulse);
			}
		}

	}

	public void DisableEnemy(){
		gameObject.SetActive (false);
	}


	void ResetSpeed(){
		currentSpeed = maxSpeed;
	} 

}
