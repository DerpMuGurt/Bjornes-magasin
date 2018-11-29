using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoseMusic : MonoBehaviour {

    public static ChoseMusic instance;
    public AudioClip musicClip;
    public AudioSource muiscSource;
    public AudioClip[] musicClipList;

    bool menu;
    bool bageri;
    bool demo;

    // Use this for initialization
    void Start () {
		
	}

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    // Update is called once per frame
    void Update () {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;


        if (sceneName == "MainMenu")
        {
            musicClip = musicClipList[0];
            muiscSource.clip = musicClip;
            if (!muiscSource.isPlaying)
            {
                muiscSource.Play();
            }
        }

       else if (sceneName == "TestDemo")
        {
            musicClip = musicClipList[1];
            muiscSource.clip = musicClip;
            if (!muiscSource.isPlaying)
            {
                muiscSource.Play();
            }
        }
        else if (sceneName == "Bageri")
        {
            musicClip = musicClipList[2];
            muiscSource.clip = musicClip;
            if (!muiscSource.isPlaying)
            {
                muiscSource.Play();
            }
        }




        if (sceneName == "TownHall")
        {

        }
    }
}
