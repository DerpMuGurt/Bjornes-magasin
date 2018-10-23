using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    //public GameObject loadingScreen;
    //public Slider slider;
    //public Text progressText;


    void Start()
	{
		//döda Object när du kommer till meny
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		if (player)
			Destroy (player);
	
	//	GameObject miniCamera = GameObject.FindGameObjectWithTag ("MinimapCamera");
	//	if (miniCamera)
	//		Destroy (miniCamera);
		
		GameObject camera = GameObject.FindGameObjectWithTag ("MainCamera");
		if (camera)
			Destroy (camera);



        //slut
    }



    public void LoadLevel(int sceneIndex)
	{
		//StartCoroutine (LoadAsynchronously (sceneIndex));
        SceneManager.LoadSceneAsync(sceneIndex);

    }

	//IEnumerator LoadAsynchronously (int sceneIndex)
	//{
	//	AsyncOperation operation = SceneManager.LoadSceneAsync (sceneIndex);

	//	loadingScreen.SetActive (true);   

	//	while (!operation.isDone)
	//	{
	//		float progress = Mathf.Clamp01 (operation.progress / .9f);

	//		slider.value = progress;
	//		progressText.text = progress * 100f + "%";

           
	//		yield return null;
 //       }
 //   }

	public void QuitGame ()
	{
		Debug.Log("QUIT!");
		Application.Quit();
	}
}
