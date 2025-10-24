using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _levelText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Initialize()
    {
        _levelText.text = "Level " + LevelManagerScript.Instance.CurrentLevel;
    }

    public void LevelCompleteButton()
    {
        LevelManagerScript.Instance.LevelComplete();
        LevelManagerScript.Instance.OpenLevel();
        Initialize();
    }

    public void LevelFailButton()
    {
        Debug.Log("Level tekrar yüklendi.");
        LevelManagerScript.Instance.OpenLevel();
    }
}
