using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCredits : MonoBehaviour {

    public AudioSource button;
    public GameObject Credits;

    void Start()
    {
        Credits.SetActive(false);
    }

    public void Creditos()
    {
        button.Play();
        Credits.SetActive(true);
    }

    public void Menu()
    {
        button.Play();
        Credits.SetActive(false);
    }
}
