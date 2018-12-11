using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public GameObject Cam1;

    void Start()
	{
        PauseMenu.canPause = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = (true);
        Time.timeScale = 0f;
    }

    public void startCutScene()
    {
        StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence()
    {
        Time.timeScale = 1f;
        Cam1.SetActive(true);
        yield return new WaitForSeconds(2f);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = (true);
        PauseMenu.canPause = true;
        SceneManager.LoadScene("TownHall");

    }

	public void QuitGame ()
	{
		Debug.Log("QUIT!");
		Application.Quit();
	}
}
