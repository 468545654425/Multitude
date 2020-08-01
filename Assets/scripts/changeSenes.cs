﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeSenes : MonoBehaviour
{

    void Awake()
    {
        if(SceneManager.GetActiveScene().name=="start")
        {
            DontDestroyOnLoad (gameObject);
            SceneManager.LoadScene(0);

        }

        
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E ))
        {
            if(SceneManager.GetActiveScene().buildIndex==0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }
            
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            if(SceneManager.GetActiveScene().buildIndex==1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
            }
            
        }
    }
}
