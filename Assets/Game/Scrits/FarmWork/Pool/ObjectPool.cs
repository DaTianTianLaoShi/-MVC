using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : SingLeton<ObjectPool>
{
    public string Resource = "";//公共资源目录
    //字典
    Dictionary<string, SubPool> Main_SupPools = new Dictionary<string, SubPool>();
    public GameObject OnSpawn(string ResourceName)//取对象
    {
        if (!Main_SupPools.ContainsKey(ResourceName))
        {
            Register(ResourceName);
        }
        SubPool subPool = Main_SupPools[ResourceName];
        return subPool.OnSpawn();
    }
    //注册对象
    public void Register(string ResourceName)
    {
        string parth = "";
        if (string.IsNullOrEmpty(ResourceName))
        {
            parth = ResourceName;
        }
        else
        {
            parth = Resource + '/' + ResourceName;
        }
        //获取资源
        GameObject go = Resources.Load(parth) as GameObject;
        //创建对象处理资源能够转入字典
        SubPool sup = new SubPool(this.transform, go);
        //装入字典
        Main_SupPools.Add(sup.Name, sup);
    }
    public void UnSpawn( GameObject go)
    {
        foreach (SubPool pool in Main_SupPools.Values)
        {
            if (pool.IsContain(go))
            {
                pool.UpSpawn(go);
                break;
            }
        }
    }
    public void UnSpawnAll()
    {
        foreach (SubPool pool in Main_SupPools.Values)
        {
            pool.AllSpawnOn();
        }
    }
    //void Start()
    //{
        
    //}
 
    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
