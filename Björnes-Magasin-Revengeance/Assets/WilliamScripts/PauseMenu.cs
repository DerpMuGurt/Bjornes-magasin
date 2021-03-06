﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;

	public GameObject pauseMenuUI;

    public static bool canPause;

    public GameObject EventManager;


    void Start()
	{
        canPause = true;
        SettinsMenu.resolutionSet = true;
        Cursor.visible = (false);
	}
	// Update is called once per frame
	void Update ()
	{
        if(DialogueManager.talking == false)
        {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("joystick button 7") && canPause == true) 
		{
			
 			if (GameIsPaused) 
			{
				Resume();
			}
			else
			{
				Pause();
			}
		}
        }

        if (canPause == true)
        {
            EventManager.SetActive(true);
        }

        if (canPause == false)
        {
            EventManager.SetActive(false);
            pauseMenuUI.SetActive(false);
        }

    }



	public void Resume ()
	{
        FindObjectOfType<Movement>().enabled = true;
   //     Cursor.lockState = CursorLockMode.Locked;
    //    Cursor.visible = (false);
		pauseMenuUI.SetActive(false);
		Time.timeScale= 1f;
		GameIsPaused = false;
	}
	void Pause ()
	{
        FindObjectOfType<Movement>().enabled = false;
     //   Cursor.lockState = CursorLockMode.None;
    //    Cursor.visible = (true);
		pauseMenuUI.SetActive(true);
		Time.timeScale= 0f;
		GameIsPaused = true;
	}

	public void LoadMenu()
	{
        canPause = false;
        pauseMenuUI.SetActive(false);
        Debug.Log ("Load Menu");
		Time.timeScale = 1f;
		GameIsPaused = false;
        SceneManager.LoadScene("MainMenu");
        FindObjectOfType<Movement>().enabled = true;
    }
	public void QuitGame()
	{
		Debug.Log ("Quitting Game");
		Application.Quit ();
	}
}
