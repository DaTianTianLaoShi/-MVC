using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{

    public string Name;//名字
    public string CardImage;//卡片信息
    public string BackGround;//背景
    public string Rond;//金币
    public int InitScore;//炮塔可放置位置
    public List<Point> Points = new List<Point>();
    public List<Point> Path = new List<Point>();
    public List<Round> Round = new List<Round>();
}
