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
        SceneManager.LoadSceneAsync(sceneIndex);

    }

	public void QuitGame ()
	{
		Debug.Log("QUIT!");
		Application.Quit();
	}
}
