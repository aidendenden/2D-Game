using System;
using UnityEngine;


/// <summary>
/// 在这个脚本里的Triggered方法决定传什么
/// </summary>
public class GameEventManager : MonoBehaviour
{
    private static readonly Lazy<GameEventManager> Lazy = new Lazy<GameEventManager>(() => new GameEventManager());

    private GameEventManager()
    {
        
    }

    public static GameEventManager Instance => Lazy.Value;

    public delegate void TriggerEventHandler(string message,StuffEnum stuffEnum, Transform _transform);

    public static event TriggerEventHandler OnTrigger;


    public void Triggered(string message,StuffEnum stuffEnum, Transform _transform)
    {
        Debug.Log("Triggered: " + message);
        if (OnTrigger != null)
            OnTrigger(message,stuffEnum, _transform);
    }

    public void AddListener(TriggerEventHandler listener)
    {
        OnTrigger += listener;
    }

    public void RemoveListener(TriggerEventHandler listener)
    {
        OnTrigger -= listener;
    }
     public void ClearEventListeners()
    {
        // 清空事件监听器
        OnTrigger = null;
    }
}


#region 监听交互的方法

// 以下是监听交互的方法
// void OnEnable()
// {
//    GameEventManager.OnTrigger += HandleTrigger;
// }
//
// void OnDisable()
// {
//      GameEventManager.OnTrigger -= HandleTrigger;
// }
//
// void HandleTrigger(string message,Transform _transform)
// {
//     Debug.Log("Trigger event received: " + message,_transform);
// }

#endregion

#region 以下是使用方法，发送事件

// GameEventManager.Instance.Triggered("to touch",transform);

#endregion

public enum StuffEnum
{
    Null,
    柴火,
    木头,
    煤油瓶,
    煤油灯,
    炉子,
    遥控器,
    烧水壶电线,
    电池,
    热水壶
}
