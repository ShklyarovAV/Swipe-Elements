using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBlock : BaseBlock
{
    public override void Initialize(float scale)
    {
        transform.localScale *= scale;
    }

    public override void Destroy()
    {

    }

    public override void Move()
    {

    }
}
