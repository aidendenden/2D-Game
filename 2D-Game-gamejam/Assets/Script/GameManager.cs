using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get { return _instance; }
    }

    void Awake()
    {
        _instance = this;
    }
    
    //
    // public GameObject 木头;
    // public GameObject 柴火;
    // public GameObject 煤油灯;
    //
    //
    // private bool woodIsReady=false;
    //
    //
    //
    // private void Start()
    // {
    //     GameEventManager.OnTrigger += HandleTrigger;
    // }
    //
    // private void HandleTrigger(string message, StuffEnum stuffenum, Transform _transform)
    // {
    //     bool caseInsensitiveComparison = message.Equals("to TriggerEnter", StringComparison.OrdinalIgnoreCase);
    //
    //     if (caseInsensitiveComparison)
    //     {
    //         var type = _transform.GetComponent<ItemTag>().gameItem;
    //         if (stuffenum == StuffEnum.炉子 && type == StuffEnum.木头&& woodIsReady==false)
    //         {
    //             木头.SetActive(true);
    //             woodIsReady = true;
    //         }
    //         
    //         if (stuffenum == StuffEnum.炉子 && type == StuffEnum.柴火&& woodIsReady==true)
    //         {
    //             柴火.SetActive(true);
    //          
    //         }
    //    
    //         
    //         if (stuffenum == StuffEnum.煤油灯 && type == StuffEnum.煤油瓶)
    //         {
    //             煤油灯.SetActive(true);
    //         }
    //         
    //     }
    // }
}