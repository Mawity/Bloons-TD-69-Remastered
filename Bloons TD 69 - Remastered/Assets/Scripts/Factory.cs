using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Factory
{

    protected int x;
    protected int y;

    public abstract GameObject createObject(int x, int y);
}
