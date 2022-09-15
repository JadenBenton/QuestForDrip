using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviousSceneGetter : MonoBehaviour
{
    public static int PreviousLevel { get; private set; }
    private void OnDestroy()
    {
        PreviousLevel = gameObject.scene.buildIndex;
    }
    private void Start()
    {
        Debug.Log(PreviousSceneGetter.PreviousLevel);  // use this in any level to get the last level.
    }
}
