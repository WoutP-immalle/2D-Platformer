﻿using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    public string levelSelect;

    public string mainMenu;

    public bool isPaused;

    public GameObject pausedMenuCanvas;
	
	// Update is called once per frame
	void Update () {

        if (isPaused)
        {
            pausedMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        } else
        {
            pausedMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseUnpause();
        }
	}

    public void PauseUnpause()
    {
        isPaused = !isPaused;
    }

    public void Resume()
    {
        isPaused = false;
    }

    public void LevelSelect()
    {
        Application.LoadLevel(levelSelect);
    }

    public void Quit()
    {
        Application.LoadLevel(mainMenu);
    }
}
