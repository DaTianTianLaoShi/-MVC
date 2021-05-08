using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScence : Controller
{
    public override void Ector(object data)
    {
        Debug.Log("执行ExitScence");
        ObjectPool.T_Instatic.UnSpawnAll();
    }
}
