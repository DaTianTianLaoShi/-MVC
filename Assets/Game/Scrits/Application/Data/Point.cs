using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point
{
    public int x;
    public int y;
    public Point(int x, int y)//构造函数没有返回值
    {
        this.x = x;
        this.y = y;
    }
    public Vector2 ReturnPositionVector2()
    {
        return new Vector2(){x=this.x,y=this.y};
    }
}
