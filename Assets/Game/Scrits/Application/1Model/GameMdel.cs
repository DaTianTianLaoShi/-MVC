using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMdel : Model
{

    #region 常量
    #endregion
    #region 事件
    #endregion
    #region 字段
    //关卡列表
    List<Level> levels = new List<Level>();
    //最大通关关卡索引
    int m_Gamerogress = -1;
    //当前游戏关卡索引
    int m_PlayLevelIndex = -1;
    //游戏当前分数
    int m_Gold = 0;
    //是否游戏中
    bool islaying = false;
    #endregion
    #region 属性
    public override string Name
    {
        get
        {
            return Consts.M_GameModel;//后续改成controller命名
        }
    }
    //返回挂卡信息
    public int LevelCount
    {
        get
        {
            return levels.Count;
        }
    }
    //似乎是什么东西的限制器
    public bool IsGameassed
    {
        get
        {
            return Gamerogress >= LevelCount - 1;
        }
    }
    //单个列表属性
    public Level playlevel
    {
        get
        {
            return levels[PlayLevelID];
        }
    }
    //返回所有列表属性
    public List<Level> ReturnAlllevel
    {
        get
        {
            return levels;
        }
    }
    public int Gamerogress
    {
        get
        {
            return m_Gamerogress;
        }
        set
        {
            m_Gamerogress = value;
        }
    }
    public int PlayLevelID { get => m_PlayLevelIndex; set => m_PlayLevelIndex = value; }
    public int Gold { get => m_Gold; set => m_Gold = value; }
    public bool Islaying { get => islaying; set => islaying = value; }
    #endregion
    #region 方法
    public void Initialize()
    {
        //创建list列表
        //构建关卡列表
        //遍历数组进行操作
    }
    #endregion
    #region Unity回调
    #endregion
    #region 事件回调
    #endregion
    #region 帮助方法
    #endregion
}
