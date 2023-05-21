using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseBlock : MonoBehaviour
{
    protected int xBoardPos;
    protected int yBoardPos;

    public abstract void Initialize(float scale);
    public abstract void Move();
    public abstract void Destroy();
}
