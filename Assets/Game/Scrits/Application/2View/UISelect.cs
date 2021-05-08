using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISelect : View
{
    #region 常量
    #endregion
    #region 事件
    #endregion
    #region 字段
    GameMdel M_gamemodel = null;
    #endregion
    #region 属性
    public override string Name
    {
        get
        {
            return null;
            //向MVC返回 k 值
        }
    }
    #endregion
    #region 方法
    //调用卡片方法
    void LocalScence()
    {

    }
    //mvc.hardevent
    public override void HardEvent(string EventName, object data)
    {
        //throw new System.NotImplementedException();
        switch (EventName)
        {
            case Consts.E_EnterScence://如果结果是E_EnterScence指令
                SceneArgs e= data as  SceneArgs;
                if (e.SceneIndex==2)
                {
                    M_gamemodel = GetModel<GameMdel>();
                }
                LocalScence();
                break;
        }

    }
    public override void RegisterEvent()
    {
        base.RegisterEvent();

    }
    #endregion
    #region Unity回调
    #endregion
    #region 事件回调
    #endregion
    #region 帮助方法
    #endregion

}
