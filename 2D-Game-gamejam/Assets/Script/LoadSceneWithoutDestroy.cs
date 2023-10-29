using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneWithoutDestroy : MonoBehaviour
{
    private static bool isInstanceCreated = false;

    private void Awake()
    {
        if (!isInstanceCreated)
        {
            DontDestroyOnLoad(gameObject);
            isInstanceCreated = true;
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
