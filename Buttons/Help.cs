﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour {
    public GameObject menu;
    public GameObject pause;
    public bool isShowing = false;
    // Use this for initialization
    void Start () {
        menu.SetActive(isShowing);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("escape"))
        {
            if(menu.activeSelf == true)
            {
                menu.SetActive(false);
                pause.SetActive(false);
                isShowing = false;
            }
        }
    }
    public void LoadStage() {
        isShowing = !isShowing;
        menu.SetActive(isShowing);
        pause.SetActive(!isShowing);
        

    }
        public void GoBack()
    {
        isShowing = !isShowing;
        menu.SetActive(isShowing);
        pause.SetActive(!isShowing);
    }
}
