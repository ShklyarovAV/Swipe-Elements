using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private int _width;
    [SerializeField] private int _height;

    [SerializeField] private BaseBlock _baseBlock;


    private BaseBlock[,] _blocks;
    private float _scaleBlock;

    public void Initialize()
    {
        _blocks = new BaseBlock[_height, _width];
        _scaleBlock = 2f;

        PlaceBlock();
    }

    private void PlaceBlock()
    {
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                BaseBlock block = Instantiate(_baseBlock, GetWorldPosition(x, y), Quaternion.identity, transform);
                block.Initialize(_scaleBlock);

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

    }
}
