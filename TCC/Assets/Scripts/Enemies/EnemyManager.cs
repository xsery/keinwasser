﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<CameraFollow>().fixedCamera = true;
//            FindObjectOfType<CameraFollow>().maxXAndY.x = transform.position.x;
//            FindObjectOfType<CameraFollow>().minXAndY.x = transform.position.x;
        }
    }
}
