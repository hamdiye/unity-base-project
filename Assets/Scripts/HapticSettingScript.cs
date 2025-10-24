using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HapticSettingScript : MonoBehaviour
{
    public UnityEngine.UI.Image HapticButtonImage;
    public Sprite HapticOnImage;
    public Sprite HapticOffImage;
    public Toggle hapticToggle;
    void Awake()
    {
        hapticToggle.isOn = PlayerPrefs.GetInt("Haptic", 1) == 1;
        HapticButtonImage.sprite = hapticToggle.isOn ? HapticOnImage : HapticOffImage;
    }
    public void HapticTriggerButton()
    {
        if (hapticToggle.isOn)
        {
            HapticButtonImage.sprite = HapticOnImage;
            PlayerPrefs.SetInt("Haptic", 1);
        }
        else
        {
            HapticButtonImage.sprite = HapticOffImage;
            PlayerPrefs.SetInt("Haptic", 0);
        }
    }
}
