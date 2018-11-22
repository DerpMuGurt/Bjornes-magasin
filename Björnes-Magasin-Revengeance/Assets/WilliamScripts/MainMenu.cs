using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    void Start()
	{
    }

    public void LoadLevel(int sceneIndex)
	{
        SceneManager.LoadScene("TestDemo");

    }

	public void QuitGame ()
	{
		Debug.Log("QUIT!");
		Application.Quit();
	}
}
