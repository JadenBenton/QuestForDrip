using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public GameObject playerObj;

    public int health;
    public int currentscene;
    public int previousscene;
    public int speed;
    public int strength;
    public int drip;
    public int coins;

    public Vector3 position;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        SaveSystem.LoadPlayerSave();
    }

    private void Start()
    {
        Debug.Log("Current Scene: " + currentscene.ToString());
    }
    private void FixedUpdate()
    {
        position = transform.position;
    }
}
