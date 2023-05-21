using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBlock : BaseBlock
{
    public override void Initialize(float scale, int spriteLayer, int xBoardPos, int yBoardPos)
    {
        transform.localScale *= scale;
        animator.Play("Idle", 0, Random.Range(0, 1f));
        sprite.sortingOrder = spriteLayer;
    }

    public override void Destroy()
    {

    }

    public override void Move()
    {

    }
}
