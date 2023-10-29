using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Manager : MonoBehaviour
{
    private static Level1Manager _instance;

    public static Level1Manager Instance
    {
        get { return _instance; }
    }


    public GameObject 木头;
    public GameObject 柴火;
    public GameObject 煤油灯;
 
    
    private bool woodIsReady=false;

    void Awake()
    {
        _instance = this;
    }

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
                woodIsReady = true;
            }
            
            if (stuffenum == StuffEnum.炉子 && type == StuffEnum.柴火&& woodIsReady==true)
            {
                柴火.SetActive(true);
             
            }
       
            
            if (stuffenum == StuffEnum.煤油灯 && type == StuffEnum.煤油瓶)
            {
                煤油灯.SetActive(true);
            }
            
        }
    }
}
