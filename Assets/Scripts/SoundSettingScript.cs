using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;


public class SoundSettingScript : MonoBehaviour
{
    public UnityEngine.UI.Image SoundButtonImage;
    public Sprite SoundOnImage;
    public Sprite SoundOffImage;
    public Toggle soundToggle;
    void Awake()
    {
        soundToggle.isOn = PlayerPrefs.GetInt("Sound", 1) == 1;
        SoundButtonImage.sprite = soundToggle.isOn ? SoundOnImage : SoundOffImage;
    }
    public void SoundTriggerButton()
    {
        if (soundToggle.isOn)
        {
            SoundButtonImage.sprite = SoundOnImage;
            PlayerPrefs.SetInt("Sound", 1);
        }
        else
        {
            SoundButtonImage.sprite = SoundOffImage;
            PlayerPrefs.SetInt("Sound", 0);
        }
    }
}
