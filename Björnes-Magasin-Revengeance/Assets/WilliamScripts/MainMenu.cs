using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    void Start()
	{
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = (true);
        Time.timeScale = 0f;
    }

    public void LoadLevel(int sceneIndex)
	{
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = (true);
        PauseMenu.canPause = true;
        SceneManager.LoadScene("TestDemo");

    }

	public void QuitGame ()
	{
		Debug.Log("QUIT!");
		Application.Quit();
	}
}
