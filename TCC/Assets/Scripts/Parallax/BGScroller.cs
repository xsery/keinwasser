using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour {

    public float speed = 0;
    private Material mat;
    private GameObject pl;
    private float pos = 0;

	// Use this for initialization
	void Start () {
        mat = GetComponent<Renderer>().material;
        pl = GameObject.FindGameObjectWithTag("MainCamera");		
	}
	
	// Update is called once per frame
	void Update () {
        // var vel = pl.GetComponent<Rigidbody>().velocity.x;
        // if (vel != 0f) {
        //   Debug.Log(vel);
        var side = pl.transform.localScale.x;
        //var side = pl.transform.localScale.x; funcionando
        pos += speed * side;

        //mat.mainTextureOffset = new Vector3(pos, 0, 0);
        //mat.mainTextureOffset = new Vector3(pos, 0, 0);
        mat.mainTextureOffset = new Vector3(pl.transform.position.x * speed, 0, 0);
        //mat.mainTextureOffset = new Vector3(pl.transform.position.x, 0, 0); funcionado
        //}


    }
}
