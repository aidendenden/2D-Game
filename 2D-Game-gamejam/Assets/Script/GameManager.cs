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


    public GameObject 木头;
    public GameObject 柴火;
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
            if (stuffenum == StuffEnum.炉子 && _transform.GetComponent<ItemTag>().gameItem == StuffEnum.木头&& woodIsReady==false)
            {
                木头.SetActive(true);
                woodIsReady = true;
            }
            
            if (stuffenum == StuffEnum.炉子 && _transform.GetComponent<ItemTag>().gameItem == StuffEnum.柴火&& woodIsReady==true)
            {
                柴火.SetActive(true);
            }
            
        }
    }
}