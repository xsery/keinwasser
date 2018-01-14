using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolume : MonoBehaviour {

    public Slider volumeSlider;
    /*public void VolumeController()
    public AudioSource volumeAudio;
    {
        volumeSlider.value = volumeAudio.volume;
    }*/

    public void OnValueChanged()
    {
        AudioListener.volume = volumeSlider.value;
    }
}
