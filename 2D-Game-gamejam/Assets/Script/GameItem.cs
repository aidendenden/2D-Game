using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// 枚举是物品属性
/// 这个方法是广播进入事件
/// </summary>
public class GameItem : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] public StuffEnum gameItem;
  

    public bool OnTrigger;
    public bool OnClick;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (OnClick)
        {
            GameEventManager.Instance.Triggered("to touch", gameItem,null);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (OnTrigger)
        {
            GameEventManager.Instance.Triggered("to TriggerEnter", gameItem,other.transform);
        }
    }

    public void UIClick()
    {
        GameEventManager.Instance.Triggered("On UI Click", gameItem,null);
    }
}