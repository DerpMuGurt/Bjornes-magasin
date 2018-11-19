using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSave : MonoBehaviour {




    void Update() {



        if (Input.GetKeyDown(KeyCode.X)) {

            LoadController.loadController.Delete();
        }

        if (Input.GetButtonDown("Save")) {


            PlayerPrefs.SetInt("Level", SceneManager.GetActiveScene().buildIndex);


            LoadController.loadController.playerPositionX = transform.position.x;
            LoadController.loadController.playerPositionY = transform.position.y;
            LoadController.loadController.playerPositionZ = transform.position.z;

            LoadController.loadController.Save();
        }

        if (Input.GetButtonDown("Load")) {

            LoadController.loadController.Load();

            SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
            transform.position = new Vector3
                (
                LoadController.loadController.playerPositionX,
                LoadController.loadController.playerPositionY,
                LoadController.loadController.playerPositionZ
                );



        }

    }
}