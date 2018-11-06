using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;

	public GameObject pauseMenuUI;


	void Start()
	{
		Cursor.visible = (false);
	}
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("joystick button 7")) 
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
		Debug.Log ("Load Menu");
		Time.timeScale = 1f;
		GameIsPaused = false;
		SceneManager.LoadScene (0);
	}
	public void QuitGame()
	{
		Debug.Log ("Quitting Game");
		Application.Quit ();
	}
}
