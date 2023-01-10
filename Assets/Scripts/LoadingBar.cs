﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingBar : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 5f;

    private float timeElapsed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading) {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
