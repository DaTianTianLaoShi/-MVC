using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//这是格子类
public class Tile : MonoBehaviour
{
    public int X;
    public int Y;
    public bool is_UpDown;
    public GameObject Data;
    public Tile(int x, int y)
    {
        X = x;
        Y = y;
    }
    public Tile(int x,int y,bool is_UpDown,GameObject gameObject )
    {
        X = x;
        Y = y;
        this.is_UpDown = is_UpDown;
        Data = gameObject;
    }

    public override string ToString()
    {
        //return base.ToString();
        return string.Format("x={0},y={1},isUpDown={2}",X,Y,is_UpDown);
    }

    // Start is called before the first frame update

}
