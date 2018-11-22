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
    }

    public void LoadLevel(int sceneIndex)
	{
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
