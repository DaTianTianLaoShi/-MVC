using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class UICard : MonoBehaviour,IPointerDownHandler
{
    public event Action<Card> OnClack;
    Card card = null;
    bool m_Isoparint = false;
    public Image ImageCard;
    public Image ImageLocad;
    public bool Isoparint
    {
        get
        {
            return  m_Isoparint;
        }
        set
        {
            m_Isoparint = value;
            Image[] images = new Image[] {ImageCard,ImageLocad };
            foreach (Image l_image in images)
            {
                Color i_C=l_image.color;
                i_C.a = m_Isoparint ? 0.5f : 1f;
                l_image.color = i_C;
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("触发鼠标点击事件");
        //throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
