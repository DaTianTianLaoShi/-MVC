using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticData : SingLeton<StaticData>
{
    //储存怪物类型的字典
    public Dictionary<int, MonsterInfo> D_moster = new Dictionary<int, MonsterInfo>();
    //储存罗卜信息的字典
    public Dictionary<int, LuoBoInfo> D_LuoBoInfo = new Dictionary<int, LuoBoInfo>();
    //储存防御塔信息的字典
    public Dictionary<int, TowerInfo> D_TowerInfo = new Dictionary<int, TowerInfo>();
    protected override void Awake()
    {
        base.Awake();
        Debug.Log("加载StaticData");
        LuoBoInit();
        TowerInit();
        MosterInit();
    }
    //加载本地萝卜命令
    public void LuoBoInit()
    {
        D_LuoBoInfo.Add(0,new LuoBoInfo {id=0,hp=200 });
    }
    //加载本地防御塔的命令
    public void TowerInit()
    {
        D_TowerInfo.Add(0, new TowerInfo { id = 1, prefabname = "", normalicon = "", disableIcon = "", maxlevel = 3, baseprice = 1, shotrate = 2, guardrange = 3, usebulletid = 0 });
    }
    //加载本地怪物命令
    public void MosterInit()
    {
        D_moster.Add(0,new MonsterInfo{id =0,hp=1,movespeed=0.5f });
    }
    //查找萝卜
    public LuoBoInfo R_LuoBoInfo(int luoboNumber)
    {
        return D_LuoBoInfo[luoboNumber];
    }
    //查找怪物
    public MonsterInfo R_MonsterInfo(int mostertype )
    {
        if (!D_moster.ContainsKey(mostertype))
        {
            Debug.Log("没有该类型怪物");
            return null;
        }
        return D_moster[mostertype];
    }
    //查找防御塔
    public TowerInfo R_TowerInfo(int towertye)
    {
        if (D_TowerInfo.ContainsKey(towertye))
        {
            Debug.Log("没有该类型防御塔");
            return null;
        }
        return D_TowerInfo[towertye];
    }
}
