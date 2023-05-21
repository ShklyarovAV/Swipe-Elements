using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEntryPoint : MonoBehaviour
{
    [SerializeField] private Board _board;
    [SerializeField] private LevelData _levelData;


    private void Awake()
    {
        _board.Initialize(_levelData);
    }
}
