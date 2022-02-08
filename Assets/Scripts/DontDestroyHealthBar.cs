using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DontDestroyHealthBar : MonoBehaviour
{

    public static DontDestroyHealthBar instance;

    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }

        else
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }



}