using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingLeton<T> : MonoBehaviour where T:MonoBehaviour
{
    private static T Instance;
    public static T T_Instatic 
    {
        get
        {
            return Instance;
        }
    }
    protected virtual void Awake()//用虚方法重写Awake
    {
        Instance = this as T;
    }
}
