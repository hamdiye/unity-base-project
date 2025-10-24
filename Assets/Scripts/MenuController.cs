using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject SettingsCanvas;
    public GameObject MenuCanvas;
    [SerializeField] private TextMeshProUGUI _levelNumberText;
    public void SettingsButtonClick()
    {
        SettingsCanvas.SetActive(true);
        MenuCanvas.SetActive(false);
    }

    public void CancelSettingsButtonClick()
    {
        Debug.Log("Ayarlar Ekranı Kapatıldı");
        SettingsCanvas.SetActive(false);
        MenuCanvas.SetActive(true);
    }

    public void Initialize()
    {
        InitializeUI();
    }
    public void InitializeUI()
    {
        _levelNumberText.text = LevelManagerScript.Instance.CurrentLevel.ToString();

    }
    public void OpenLevelButton()
    {
        SceneManager.LoadScene("GameScene");
        LevelManagerScript.Instance.OpenLevel();
    }
}
