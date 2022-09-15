using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public bool interactedwith;

    public TextMeshProUGUI Text;
    public GameObject InteractionCanvas;
    //If interaction is char

    public bool istriggered;
    public bool Interact;
    public int spacePresses;

    public string message1;
    public string message2;
    public string message3;
    public string message4;
    public string message5;
    public string message6;
    public string message7;
    public string message8;
    public string message9;
    public string message10;

    public bool hasviwedmessage1;
    public bool hasviwedmessage2;
    public bool hasviwedmessage3;
    public bool hasviwedmessage4;
    public bool hasviwedmessage5;
    public bool hasviwedmessage6;
    public bool hasviwedmessage7;
    public bool hasviwedmessage8;
    public bool hasviwedmessage9;
    public bool hasviwedmessage10;

    public Queue Message;

    // Start is called before the first frame update
    void Start()
    {
        Text.text = message1;
        spacePresses = 0;
        InteractionCanvas.SetActive(false);
        Interact = false;
        istriggered = false;

        hasviwedmessage1 = true;
        hasviwedmessage2 = false;
        hasviwedmessage3 = false;
        hasviwedmessage4 = false;
        hasviwedmessage5 = false;
        hasviwedmessage6 = false;
        hasviwedmessage7 = false;
        hasviwedmessage8 = false;
        hasviwedmessage9 = false;
        hasviwedmessage10 = false;

    }
    void Update()
    {
        //Input Updates
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePresses++;
        }
        if (Input.GetKeyDown(KeyCode.E) && istriggered)
        {
            Interact = true;
            InteractionCanvas.SetActive(true);

            Text.text = message1;
        }

        //Interaction Update
        if (Interact && spacePresses == 1)
        {
            Text.text = message2;
            hasviwedmessage2 = true;
        }
        if (Interact && spacePresses == 2)
        {
            Text.text = message3;
            hasviwedmessage2 = true;
        }
        if (Interact && spacePresses == 3)
        {
            Text.text = message4;
            hasviwedmessage4 = true;
        }
        if (Interact && spacePresses == 4)
        {
            Text.text = message5;
            hasviwedmessage5 = true;
        }
        if (Interact && spacePresses == 5)
        {
            Text.text = message6;
            hasviwedmessage6 = true;
        }
        if (Interact && spacePresses == 6)
        {
            Text.text = message7;
            hasviwedmessage7 = true;
        }
        if (Interact && spacePresses == 7)
        {
            Text.text = message8;
            hasviwedmessage8 = true;
        }
        if (Interact && spacePresses == 8)
        {
            Text.text = message9;
            hasviwedmessage9 = true;
        }
        if (Interact && spacePresses == 9)
        {
            Text.text = message10;
            hasviwedmessage10 = true;
        }
        if (Interact && spacePresses == 10)
        {
            InteractionCanvas.SetActive(false);
        }
        if (Text.text == "")
        {
            InteractionCanvas.SetActive(false);
            Interact = !Interact;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        spacePresses = 0;
        istriggered = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        InteractionCanvas.SetActive(false);
        istriggered = false;
        Interact = false;
        spacePresses = 0;
    }
}
