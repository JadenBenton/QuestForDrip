using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Player;
    public int movementspeed;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(Player.transform.position.x, Player.transform.position.y, transform.position.z);
        transform.position = Vector3.Slerp(transform.position, newPosition, movementspeed * Time.deltaTime);
    }
}
