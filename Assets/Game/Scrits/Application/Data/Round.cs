using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round 
{
    public int Monster;//怪物类型
    public int Count;//怪物数量
    public Round(int monster,int count )
    {
        this.Monster = monster;
        this.Count = count;
    }
}
