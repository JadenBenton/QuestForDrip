using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int health;
    public float[] position;
    public float speed;
    public int currentscene;
    public int previousscene;
    public int strength;
    public int drip;
    public int coins;

    public PlayerData(Player player) {

        health = player.health;
        speed = player.speed;
        drip = player.drip;
        coins = player.coins;
        strength = player.strength;
        currentscene = player.currentscene;
        previousscene = PreviousSceneGetter.PreviousLevel;

        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }

}
