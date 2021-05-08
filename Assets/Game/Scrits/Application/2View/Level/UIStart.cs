using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStart : View
{
    public override string Name
    {
        get
        {
            return Consts.V_UIStart;
        }
    }

    public override void HardEvent(string EventName, object data)
    {
       // throw new System.NotImplementedException();
        Debug.Log("跳转到场景2");
    }
    public void GoToSelectScence()
    {
        Game.T_Instatic.LoadSence(2);
    }
}
