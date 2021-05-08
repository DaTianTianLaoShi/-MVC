using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//事件类
public class TileClickEventArge : EventArgs
{
    public int MousterButton;
    public Tile tile;

    public TileClickEventArge(int mosterButton,Tile tile)
    {
        this.MousterButton = mosterButton;
        this.tile = tile;
    }
} 
public class Map :MonoBehaviour 
{
    #region 常量
    public const int RowConst=8;//横向个数
    public const int ColumnCount = 12;//纵向个数
    #endregion
    #region 事件
    public static event EventHandler<TileClickEventArge> ClickEvent;
    #endregion
    #region 字段
    //用来储存所有临时变量的
    float MapWith;//整张地图的宽度
    float MapHeight;
    float TileWith;//每个格子的宽度
    float TileHeight;

    List<Tile> m_grid = new List<Tile>();
    List<Tile> m_road = new List<Tile>();

    Level m_Level;

    public bool drawGizoms = true;

    public SpriteRenderer BackGroundSriteRender;
    public SpriteRenderer RoadSpriteRender;
    #endregion
    #region 属性
    public Level Level { get => m_Level; set => m_Level = value; }
    public List<Tile> Grid { get => m_grid; set => m_grid = value; }
    public List<Tile> Road { get => m_road; set => m_road = value; }
    #endregion
    #region 方法
    public void DrawLine()
    {
        Gizmos.color = Color.blue;

    }
    //在sence场景中每帧执行
    public void OnDrawGizmos()
    {
        //Debug.Log("123456");
        if (!drawGizoms) return;
        //在外部计算好模型
        //Gizmos.DrawLine();
        
    }
    private void Start()
    {
        //在第一帧的时候获取数据
        CalcuateSize();
    }
    private void Update()
    {
        
    }
    #endregion
    #region Unity回调
    #endregion
    #region 事件回调
    #endregion
    #region 帮助方法
    //计算地图长宽
    void CalcuateSize()
    {
        Vector2 LeftDown = new Vector2(0,0);
        Vector2 p1 = Camera.main.ViewportToWorldPoint(LeftDown);//视口坐标转世界坐标
        Vector2 RightUp = new Vector2(1,1);
        Vector2 p2 = Camera.main.ViewportToWorldPoint(RightUp);
        Debug.Log(string.Format("点击的位置X{0}，Y{1}",p1,p2));//打印视口点击位置
        //计算地图宽度
        MapWith = p2.x - p1.x;
        MapHeight = p2.y - p1.y;
        //计算每个格子所需要的宽度
        TileWith = MapWith / RowConst;
        TileHeight = MapHeight / ColumnCount;
    }
    void DrawPoint()//画图方法
    {
        Gizmos.color = Color.green;//画线方法为绿色
        for (int i=0;i<=RowConst;i++)
        {
            Vector2 form = new Vector2();
            Vector2 to = new Vector2();
        }
        for (int y=0;y<=ColumnCount;y++)
        {

        }
    }

    #endregion
}
