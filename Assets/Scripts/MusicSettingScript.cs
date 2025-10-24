using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSettingScript : MonoBehaviour
{
    public UnityEngine.UI.Image MusicButtonImage;
    public Sprite MusicOnImage;
    public Sprite MusicOffImage;
    public Toggle musicToggle;

    void Awake()
    {
        musicToggle.isOn = PlayerPrefs.GetInt("Music", 1) == 1;
        MusicButtonImage.sprite = musicToggle.isOn ? MusicOnImage : MusicOffImage;
    }
    public void MusicTriggerButton()
    {
        if (musicToggle.isOn)
        {
            MusicButtonImage.sprite = MusicOnImage;
            PlayerPrefs.SetInt("Music", 1);
        }
        else
        {
            MusicButtonImage.sprite = MusicOffImage;
            PlayerPrefs.SetInt("Music", 0);
        }
    }
}
