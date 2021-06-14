﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Sprite[] texture;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.unscaledTime < InfoShared.initTime + 4)
        {
            Time.timeScale = 0;
            GetComponent<Image>().sprite = texture[(int)(Time.unscaledTime - InfoShared.initTime)];
        }
        else
        {
            Time.timeScale = 1;
            Destroy(gameObject);
        }
    }
}
