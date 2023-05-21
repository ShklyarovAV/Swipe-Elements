using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseBlock : MonoBehaviour
{
    [SerializeField] protected Animator animator;
    [SerializeField] protected SpriteRenderer sprite;

    protected int xBoardPos;
    protected int yBoardPos;

    public abstract void Initialize(float scale, int spriteLayer, int xBoardPos, int yBoardPos);
    public abstract void Move();
    public abstract void Destroy();
}
