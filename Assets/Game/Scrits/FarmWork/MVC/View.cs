using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class View : MonoBehaviour
{
    //视图事件名称标识
    public abstract string Name { get; }
    public abstract void HardEvent(string EventName, object data);
    [HideInInspector]
    //关心事件
    public List<string> AttationEvent = new List<string>();
    // Start is called before the first frame update
    //注册关心事件
    public virtual void RegisterEvent()
    {
        Debug.Log("执行view，registerEvent");
    }
    //获取模型事件
    protected T GetModel<T>() where T : Model
    {
        return MVC.GetModel<T>();
    }
    //发送消息
    protected void SendEvent(string Eventname,object data=null)
    {
        MVC.SendEvent(Eventname,data);
    }
}
