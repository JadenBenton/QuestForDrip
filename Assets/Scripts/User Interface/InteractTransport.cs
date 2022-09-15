using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractTransport : MonoBehaviour
{
    public int sceneIndex;

    public bool isactive;
    public bool keypressed;

    public GameObject Player;
    public string TransporterName;
    GameObject Transporter;

    private void Start()
    {
        Transporter = GameObject.Find(TransporterName);
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        isactive = true;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        isactive = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            keypressed = true;
        }
        else
        {
            keypressed = false;
        }
    }
    private void FixedUpdate()
    {
        if (isactive)
        {
            if (keypressed)
            {
                SceneManager.LoadScene(sceneIndex);
                Player.transform.position = Transporter.transform.position;
            }
        }
    }
}
