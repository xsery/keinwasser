using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

	public int damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(Collider other){
		EnemyMovement enemy = other.GetComponent<EnemyMovement> ();
		if (enemy != null) {
			enemy.TookDamage (damage);
		}

	}  
}
