using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundVolume : MonoBehaviour
{
    public List<AudioSource> bgmVolume;
    public List<AudioSource> seVolume;

    public List<Button> addSeButtonList;

    public AudioSource buttonClickSE;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < addSeButtonList.Count; i++){
            addSeButtonList[i].onClick.AddListener(OnClickSE);
        }
        void OnClickSE(){
            buttonClickSE.Play();
        }
        BGMVolume();
        SEVolume();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BGMVolume()
    {
        for(int i = 0; i < bgmVolume.Count; i++)
        {
            bgmVolume[i].volume = GlovalValue.bgmVolume;
        }
    }

    public void SEVolume()
    {
        for (int i = 0; i < seVolume.Count; i++)
        {
            seVolume[i].volume = GlovalValue.seVolume;
        }
    }
}
