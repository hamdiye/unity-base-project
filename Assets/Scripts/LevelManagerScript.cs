using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManagerScript : MonoBehaviour
{
    public static LevelManagerScript Instance;

    private int _currentLevel;
    public int CurrentLevel
    {
        get
        {
            return _currentLevel;
        }
        set
        {
            _currentLevel = value;
        }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    public void Initialize()
    {
        CurrentLevel = PlayerPrefs.GetInt("Level", 1);
    }
    public void LevelComplete()
    {
        CurrentLevel++;
        PlayerPrefs.SetInt("Level", CurrentLevel);
    }
    public void OpenLevel()
    {
        
    }
}
