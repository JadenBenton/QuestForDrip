using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionManager : MonoBehaviour
{
    GameObject Player;

    public Vector3 currentplayerposition;
    public Vector3 previousplayerposition;

    // Start is called before the first frame update
    void Start()
    {
        previousplayerposition = currentplayerposition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentplayerposition = Player.transform.position;
    }
}
