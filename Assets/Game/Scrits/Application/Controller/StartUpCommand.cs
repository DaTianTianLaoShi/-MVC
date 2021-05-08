using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUpCommand : Controller
{
    public override void Ector(object data)
    {
        Debug.Log("正在加载命令");
        //注册模型(Model)

       // RegisterModel();
        //注册命令(Controller)
        RegisterController(Consts.E_EnterScence,typeof(EnterSence));
        RegisterController(Consts.E_ExistScence,typeof(ExitScence));
        RegisterController(Consts.E_EndLevel,typeof(EndLevel));
        RegisterController(Consts.E_StartLevel,typeof(Startlevel));
        RegisterController(Consts.E_CountDownComplete,typeof(CountDownComplete));
        //初始化
        //进入开始界面
        Game.T_Instatic.LoadSence(1);
        Debug.Log("信息加载完成");
    }

    // Start is called before the first frame update
}
