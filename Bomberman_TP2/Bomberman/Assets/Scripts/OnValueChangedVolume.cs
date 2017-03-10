using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnValueChangedVolume : MonoBehaviour {
    public Slider mySlider;
    public AudioSource AudioSource;
    public AudioSource AudioSource1;
    public AudioSource AudioSource2;
    public AudioSource AudioSource3;
    public AudioSource AudioSource4;


    public void OnValueChangeMaster()
    {
        AudioSource.volume = mySlider.value;
        AudioSource1.volume = mySlider.value;
        AudioSource2.volume = mySlider.value;
        AudioSource3.volume = mySlider.value;
        AudioSource4.volume = mySlider.value;
    }
    public void OnValueChangeMusic()
    {
        AudioSource.volume = mySlider.value;   
    }
    public void OnValueChangeSFX()
    {
        AudioSource.volume = mySlider.value;
        AudioSource1.volume = mySlider.value;
        AudioSource2.volume = mySlider.value;
        AudioSource3.volume = mySlider.value;
    }
}
