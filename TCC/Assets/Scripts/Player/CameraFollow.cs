using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform playerTransform;
	public float minPosition;
	public float maxPosition;

	private Transform camTransform;


	// Use this for initialization
	void Start () {

		camTransform = GetComponent<Transform> ();
		
	}

	// Update is called once per frame
	void Update () {

		if (playerTransform.position.x < minPosition) {
			camTransform.position = new Vector3 (-8f, camTransform.position.y, camTransform.position.z);
		}

		if (playerTransform.position.x > maxPosition) {
			camTransform.position = new Vector3 (15f, camTransform.position.y, camTransform.position.z);
		}

		if (playerTransform.position.x >= minPosition && playerTransform.position.x <= maxPosition) {
			camTransform.position = Vector3.Lerp (camTransform.position, 
				new Vector3 (playerTransform.position.x, camTransform.position.y, camTransform.position.z),
				1f);
		}
			
	}
}
