using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public Slider bgmVolumeSlider;
    public Slider seVolumeSlider;

    public SoundVolume soundVolume;

    // Start is called before the first frame update
    void Start()
    {
        bgmVolumeSlider.value = GlovalValue.bgmVolume * 5;
        seVolumeSlider.value = GlovalValue.seVolume * 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BGMVolume(){
        GlovalValue.bgmVolume = (bgmVolumeSlider.value / 5);
        soundVolume.BGMVolume();
        Debug.Log(GlovalValue.bgmVolume);
    }
    public void SEVolume(){
        GlovalValue.seVolume = (seVolumeSlider.value / 2);
        soundVolume.SEVolume();
        Debug.Log(GlovalValue.seVolume);
    }
}
