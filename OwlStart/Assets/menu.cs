﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level1() {
        SceneManager.LoadScene("world1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("world2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("world3");
    }

}
