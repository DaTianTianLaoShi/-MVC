using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationBase<T> :SingLeton<T> where T :MonoBehaviour 
{
    // Start is called before the first frame update
    //注册控制器
    protected void RegisterController( string EventName,Type ContrllerName )
    {
        MVC.RegisterController(EventName,ContrllerName);
    }
    protected void SendEvend(string EventName ,object ObjectData=null)
    {
        MVC.SendEvent(EventName,ObjectData);
    }
}
