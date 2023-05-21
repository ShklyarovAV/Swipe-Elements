using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelData", menuName = "Level/LevelData", order = 1)]
public class LevelData : ScriptableObject
{
    [SerializeField] private int _widthBoard;
    [SerializeField] private int _heightBoard;

    [SerializeField] private List<BlockTypesData> _blockTypes;

    public int GetWigthBoard => _widthBoard;
    public int GetHeightBoard => _heightBoard;
    public List<BlockTypesData> GetBlockTypesDatas => _blockTypes;
}

[System.Serializable]
public class BlockTypesData
{
    public List<BlockType> BlockTypes;
}


