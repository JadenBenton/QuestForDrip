using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public GameObject Options;
    public bool isactive;
    // Start is called before the first frame update
    void Start()
    {
        Options.SetActive(false);
        isactive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (isactive)
            {
                isactive = false;
            }
            else
            {
               isactive=true;
            }
        }
    }
    private void FixedUpdate()
    {
        switch (isactive)
        {
            case true:
                Options.SetActive(true); break;
            case false:
                Options.SetActive(false); break;
        }
    }
}
