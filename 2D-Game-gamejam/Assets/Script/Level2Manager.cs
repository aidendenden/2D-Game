using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Manager : MonoBehaviour
{
    // private static Level2Manager _instance;
    //
    // public static Level2Manager Instance
    // {
    //     get { return _instance; }
    // }


    public GameObject 电线ui;
    public GameObject 热水壶开;
    public GameObject 电池;
    public GameObject 遥控器;
   
    public GameObject 电脑开;
    public GameObject 道具遥控器关UI;
    public GameObject 道具遥控器开UI;
    public GameObject 空调开;

    public GameObject 关闭遥控器;

    public GameObject 控制器;

    private bool powerIsReady = false;
    private bool electricWireIsReady = false;

    private bool pcPower=false;
    
    public CameraSceneChange Scene;

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
            if (stuffenum == StuffEnum.热水壶 && type == StuffEnum.烧水壶电线)
            {
                电线ui.SetActive(false);
                热水壶开.SetActive(true);
                electricWireIsReady = true;
                SelectObjManager.Instance.isGoToDrag = true;
            }

            if (stuffenum == StuffEnum.遥控器 && type == StuffEnum.电池)
            {
                电池.SetActive(false);
                遥控器.SetActive(false);
                道具遥控器关UI.SetActive(false);
                道具遥控器开UI.SetActive(true);
                SelectObjManager.Instance.isGoToDrag = true;
            }
        }
    }

    public void StartPower()
    {
        powerIsReady = true;
    }

    public void PCStart()
    {
        if ( powerIsReady && electricWireIsReady)
        {
            pcPower = !pcPower;
            电脑开.SetActive(pcPower);
        }
    }
    
    public void AirConditionerOpen()
    {
        if (Scene.nowScene == 3 && powerIsReady && electricWireIsReady)
        {
            空调开.SetActive(true);
            关闭遥控器.SetActive(false);
            控制器.SetActive(false);
        }
    }
}