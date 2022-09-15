using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

public static class SaveSystem 
{
    public static void SavePlayer(Player player) 
    {
        BinaryFormatter binformatter = new BinaryFormatter();
        string filepath = Application.persistentDataPath + "/playerdata.drp";

        FileStream filestream = new FileStream(filepath, FileMode.Create);
        PlayerData filedata = new PlayerData(player);

        binformatter.Serialize(filestream, filedata);
        filestream.Close();
    }

    public static PlayerData LoadPlayerSave()
    {
        string filepath = Application.persistentDataPath + "playerdata.drp";
        if (File.Exists(filepath))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream filestream = new FileStream(filepath, FileMode.Open);

            PlayerData data = formatter.Deserialize(filestream) as PlayerData;
            filestream.Close();
            return data;
        }
        else
        {
            Debug.Log("No Save File at " + filepath);
            return null;
        }
    }
}
