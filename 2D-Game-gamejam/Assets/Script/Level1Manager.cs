using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Manager : MonoBehaviour
{
    // private static Level1Manager _instance;

    // public static Level1Manager Instance
    // {
    //     get { return _instance; }
    // }


    public GameObject 柴火;
    public GameObject 柴火UI;
    public GameObject 煤油灯;
    public GameObject 煤油灯UI;
    public GameObject 木头;
    public GameObject 木头UI;
    
    public GameObject 控制器;
    
    private bool woodIsReady=false;

    // void Awake()
    // {
    //     _instance = this;
    // }

    private void Start()
    {
        GameEventManager.OnTrigger += HandleTrigger;
    }

    private void HandleTrigger(string message, StuffEnum stuffenum, Transform _transform)
    {
        bool caseInsensitiveComparison = message.Equals("to TriggerEnter", StringComparison.OrdinalIgnoreCase);

        if (caseInsensitiveComparison)
        {
            var type = _transform.GetComponent<ItemTag>().gameItem;
            if (stuffenum == StuffEnum.炉子 && type == StuffEnum.木头&& woodIsReady==false)
            {
                木头.SetActive(true);
                木头UI.SetActive(false);
                woodIsReady = true;
                SelectObjManager.Instance.isGoToDrag = true;
            }
            
            if (stuffenum == StuffEnum.炉子 && type == StuffEnum.柴火&& woodIsReady==true)
            {
                柴火.SetActive(true);
                柴火UI.SetActive(false);
                控制器.SetActive(false);
                SelectObjManager.Instance.isGoToDrag = true;
            }
       
            
            if (stuffenum == StuffEnum.煤油灯 && type == StuffEnum.煤油瓶)
            {
                煤油灯.SetActive(true);
                煤油灯UI.SetActive(false);
                SelectObjManager.Instance.isGoToDrag = true;
            }
            
        }
    }
}
