using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public class LoadController : MonoBehaviour {

    public static LoadController loadController;

    public float playerPositionX;
    public float playerPositionY;
    public float playerPositionZ;




    void Awake() {

        if (loadController == null) {

            DontDestroyOnLoad(gameObject);
            loadController = this;

        }
        else if (loadController != this) {

            Destroy(gameObject);
        }

    }

    public void Save() {

        BinaryFormatter bf = new BinaryFormatter();

        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");


        PlayerData data = new PlayerData();

        data.playerPosX = playerPositionX;
        data.playerPosY = playerPositionY;
        data.playerPosZ = playerPositionZ;


        bf.Serialize(file, data);
        file.Close();

    }

    public void Load() {

        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat")) {

            BinaryFormatter bf = new BinaryFormatter();

            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);

            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            playerPositionX = data.playerPosX;
            playerPositionY = data.playerPosY;
            playerPositionZ = data.playerPosZ;
        }
    }

    public void Delete() {

        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat")) {

            File.Delete(Application.persistentDataPath + "/playerInfo.dat");

        }
    }
}

[Serializable]
class PlayerData {

    public float playerPosX;
    public float playerPosY;
    public float playerPosZ;
}