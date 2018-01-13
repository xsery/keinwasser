using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour {

    public AudioSource button;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (AudioListener.pause)
        {
            anim.SetBool("Mute", true);
        }
        else
        {
            anim.SetBool("Mute", false);
        }
    }

    public void Mute()
    {
        button.Play();
        AudioListener.pause = !AudioListener.pause;
    }
}
