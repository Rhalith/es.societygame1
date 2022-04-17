using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider slider;
    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        slider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
    }
    public void SetLevel()
    {
        float sliderValue = slider.value;
        audioMixer.SetFloat("MusicVol", sliderValue);
        PlayerPrefs.SetFloat("MusicVolume", sliderValue);
    }
}
