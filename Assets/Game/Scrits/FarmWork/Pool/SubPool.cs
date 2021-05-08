using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubPool : MonoBehaviour
{
    GameObject Sub_gameObject;
    Transform Sub_Parenttransform;
    List<GameObject> GameObjects = new List<GameObject>();
    // Start is called before the first frame update
     
    public string Name
    {
        get
        {
            return Sub_gameObject.name;
        }
    }
    public SubPool(Transform ParentTransform,GameObject go )
    {
        Sub_Parenttransform = ParentTransform;
        Sub_gameObject = go;
    }
    public GameObject OnSpawn()
    {
        GameObject go = null;
        foreach (GameObject gam in GameObjects  )
        {
            if (!gam.activeSelf)
            {
                go = gam;
                break;
            }
        }
        if (go==null)
        {
            go.SetActive(false);
        }
        go.SetActive(true);
        go.SendMessage("OnSpawn",SendMessageOptions.DontRequireReceiver);
        return go;
    }
    public void UpSpawn(GameObject go)
    {
        if (IsContain(go))
        {
            go.SendMessage("UpSpawn",SendMessageOptions.DontRequireReceiver);
            go.SetActive(false);
        }
    }
    public bool IsContain(GameObject go)
    {
        return GameObjects.Contains(go);
    }
    public void AllSpawnOn()
    {
        foreach(GameObject obj in GameObjects)
        {
            if (obj.activeSelf)
            {
                UpSpawn(obj);
            }
        }
    }
}
