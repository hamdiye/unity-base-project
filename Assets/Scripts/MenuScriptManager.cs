using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScriptManager : MonoBehaviour
{
    [SerializeField] private LevelManagerScript _levelManagerScript;
    [SerializeField] private MenuController _menuController;
    // Start is called before the first frame update
    void Start()
    {
        _levelManagerScript.Initialize();
        _menuController.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
