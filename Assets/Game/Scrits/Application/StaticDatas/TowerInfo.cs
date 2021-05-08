using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerInfo : MonoBehaviour
{
    private int ID;
    private string PrefabName;//预制物名字
    private string NormalIcon;//可用图标
    private string DisableIcon;//不可用图标
    private int BasePrice;//基本价格 ---不同的等级价格不一样
    private int MaxLevel;//最大等级
    private float GuardRange;//炮塔的切斜度
    private int ShotRate;//每秒发送多少颗子弹
    private int UseBulletID;//用的哪号子弹

    public int id { get => ID; set => ID = value; }
    public string prefabname { get => PrefabName; set => PrefabName = value; }
    public string normalicon { get => NormalIcon; set => NormalIcon = value; }
    public string disableIcon { get => DisableIcon; set => DisableIcon = value; }
    public int baseprice { get => BasePrice; set => BasePrice = value; }
    public int maxlevel { get => MaxLevel; set => MaxLevel = value; }
    public float guardrange { get => GuardRange; set => GuardRange = value; }
    public int shotrate { get => ShotRate; set => ShotRate = value; }
    public int usebulletid { get => UseBulletID; set => UseBulletID = value; }
}
