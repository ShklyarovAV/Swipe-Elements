using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private int _width;
    [SerializeField] private int _height;

    [SerializeField] private List<BaseBlock> _baseBlocks;


    private BaseBlock[,] _blocks;
    private float _scaleBlock;

    public void Initialize(LevelData levelData)
    {
        _width = levelData.GetWigthBoard;
        _height = levelData.GetHeightBoard;

        _blocks = new BaseBlock[_height, _width];
        _scaleBlock = 2f;

        PlaceBlock(levelData.GetBlockTypesDatas);
    }

    private void PlaceBlock(List<BlockTypesData> blockTypes)
    { 
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                int index = _baseBlocks.FindIndex((d) => d.GetBlockType == blockTypes[x].BlockTypes[y]);
                if(index == -1)
                {
                    continue;
                }

                BaseBlock block = Instantiate(_baseBlocks[index], GetWorldPosition(x, y), Quaternion.identity, transform);
                block.Initialize(_scaleBlock, y * 10 + x, x, y);

                _blocks[y, x] = block;
            }
        }
    }

    private Vector2 GetWorldPosition(int x, int y)
    {
        return new Vector2(transform.position.x - _width / 2f + x, transform.position.y - _height / 2f + y) * _scaleBlock + Vector2.one * _scaleBlock / 2f;
    }

    public void Clear()
    {
        if(_blocks != null)
        {
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    if(_blocks[y,x] != null)
                    {
                        Destroy(_blocks[y,x].gameObject);
                    }
                }
            }
        }
    }
}
