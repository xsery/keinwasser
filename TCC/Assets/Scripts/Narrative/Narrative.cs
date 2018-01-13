using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Narrative : MonoBehaviour {

    public float DurationOfTime;
    public string ScenePath;

	// Use this for initialization
	void Start () {
        StartCoroutine("narrative");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator narrative()
    {
        yield return new WaitForSeconds(DurationOfTime);
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/" + ScenePath);
    }
}
