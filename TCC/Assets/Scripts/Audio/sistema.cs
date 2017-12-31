using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sistema : MonoBehaviour {

	public void SomDesligar () {
        AudioListener.pause = true;
	}

    public void SomLigar()
    {
        AudioListener.pause = false;
    }
}
