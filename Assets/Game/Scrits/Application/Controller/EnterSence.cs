using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterSence : Controller
{
    public override void Ector(object data)
    {
        //switch
        Debug.Log("加载界面模型");
        SceneArgs scene_int = data as SceneArgs;
        switch (scene_int.SceneIndex)
        {
            case 0:
                Debug.Log("初始显示界面");
                break;
            case 1:
                Debug.Log("加载第二场景界面");
                break;
            case 2:
                Debug.Log("加载第三场景界面");
                break;
            case 3:
                Debug.Log("加载第三场景界面");
                break;
            case 4:
                Debug.Log("加载第四场景界面");
                break;
            default: break;
        }

    }
}
