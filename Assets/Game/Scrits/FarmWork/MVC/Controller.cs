using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controller
{
    private int a;
    public int A { get => a; set => a = value; }
    //写法变了
    public abstract void Ector(object data);
    protected T GetView <T>()where T:View
    {
        return MVC.GetView<T>()as T ;
    }
    protected T GetModel<T>() where T : Model
    {
        return MVC.GetModel<T>() as T;
    } 
    //注册模型
    protected void RegisterModel(Model model)
    {

    }
    //注册视图
    protected void RegisterView(View view)
    {

    }
     //注册事件
    protected void RegisterController(string EventName,Type ControllerTyep)
    {
        MVC.RegisterController(EventName,ControllerTyep);
    }
}

