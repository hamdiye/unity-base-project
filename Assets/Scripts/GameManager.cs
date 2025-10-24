using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private LevelController _levelController;
    // Start is called before the first frame update
    void Start()
    {
        _levelController.Initialize();
    }
}
