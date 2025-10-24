using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NotificationSettingScript : MonoBehaviour
{
    public Toggle notificationToggle;
    public Sprite notificationOnImage;
    public Sprite notificationOffImage;
    public GameObject notificationButton;
    public TextMeshProUGUI text;
    void Awake()
    {
        notificationToggle.isOn = PlayerPrefs.GetInt("Notification", 1) == 1;
        NotificationTriggerButton();
    }

    public void NotificationTriggerButton()
    {
        if (notificationToggle.isOn)
        {
            notificationButton.GetComponent<Image>().sprite = notificationOnImage;
            text.text = "Açık";
            notificationButton.GetComponent<HorizontalLayoutGroup>().reverseArrangement = false;
            PlayerPrefs.SetInt("Notification", 1);
        }
        else
        {
            notificationButton.GetComponent<Image>().sprite = notificationOffImage;
            text.text = "Kapalı";
            notificationButton.GetComponent<HorizontalLayoutGroup>().reverseArrangement = true;
            PlayerPrefs.SetInt("Notification", 0);
        }
    }
}
