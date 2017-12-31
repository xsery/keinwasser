using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour {

    private Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        anim.SetInteger("Weapon", GameManager.Instance.getWeapon());

        if (Input.GetButtonDown("Weapon"))
        {
            GameManager.Instance.weaponExchange();
        }
    }
}
