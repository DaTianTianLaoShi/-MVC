using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MVC 
{
    //public static int a = 10;静态类要全是静态成员 
    public static Dictionary<string, Model> D_Model = new Dictionary<string, Model>();
    public static Dictionary<string, View> D_View = new Dictionary<string, View>();
    public static Dictionary<string, Type> CommadeMap = new Dictionary<string, Type>();
    public static void RegisterModel(Model model)
    {
        D_Model[model.Name] = model;
    }
    public static void RegisterView(View view)
    {
        if (D_View.ContainsKey(view.name))
        {
            D_View.Remove(view.name);
        }
        //注册关心事件 n

        //关心事件放入列表
        D_View[view.name] = view;
    }
    public static void RegisterController(string EventName ,Type Type_controller )
    {
        CommadeMap[EventName] = Type_controller;
    }
    public static T GetModel<T>() where T : Model
    {
        foreach (Model M in D_Model.Values)
        {
            if (M is T)
            {
                return (T)M;
            }
        }
        return null;
    }
    public static T GetView<T>() where T : View
    {
        foreach (View t in D_View.Values)
        {
            if (t is T)
            {
                return (T)t;
            }
        }
        return null;
    }

    public static void SendEvent(string EventName,object data=null)
    {
        if (CommadeMap.ContainsKey(EventName))
        {
            Type type = CommadeMap[EventName];
            Controller c = Activator.CreateInstance(type) as Controller;
            c.Ector(data);
        }
        //显示层
        foreach (View v in D_View.Values )
        {
            if (v.AttationEvent.Contains(EventName))
            {
                v.HardEvent(EventName,data);
            } 
        }
    }
}
