using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class CameraSceneChange : MonoBehaviour
{
    public GameObject[] sceneAndButton;

    public int nowScene;
    


    private int _nowScene
    {
        set
        {
            nowScene = Mathf.Clamp(value, 0, 3);
        }
        get
        {
            return nowScene;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeCameraScene(int offset)
    {
        _nowScene += offset;
        if (_nowScene==0)
        {
            for (int i = 0; i < sceneAndButton.Length; i++)
            {
                if (i==1||i==2)
                {
                    sceneAndButton[i].SetActive(true);
                }
                else
                {
                    sceneAndButton[i].SetActive(false);
                }
            }
        }
        if (_nowScene==1)
        {
            for (int i = 0; i < sceneAndButton.Length; i++)
            {
                if (i==0||i==1||i==3)
                {
                    sceneAndButton[i].SetActive(true);
                }
                else
                {
                    sceneAndButton[i].SetActive(false);
                }
            } 
        }
        if (_nowScene==2)
        {
            
            for (int i = 0; i < sceneAndButton.Length; i++)
            {
                if (i==0||i==1||i==4)
                {
                    sceneAndButton[i].SetActive(true);
                }
                else
                {
                    sceneAndButton[i].SetActive(false);
                }
            } 
        }
        if (_nowScene==3)
        {
            for (int i = 0; i < sceneAndButton.Length; i++)
            {
                if (i==0||i==5)
                {
                    sceneAndButton[i].SetActive(true);
                }
                else
                {
                    sceneAndButton[i].SetActive(false);
                }
            } 
        }
    }
    
}
