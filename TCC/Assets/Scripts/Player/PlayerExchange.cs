using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExchange : MonoBehaviour {

    private Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Helper", GameManager.Instance.getHelper());

        if (Input.GetButtonDown("Helper") && GameManager.Instance.getPhase() == 1 && GameManager.Instance.getPhase() == 5)
        {
            GameManager.Instance.characterExchange();
        }
    }
}
