using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject InventoryCanvas;
    public bool isactive;
    // Start is called before the first frame update
    void Start()
    {
        InventoryCanvas.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("test");
            isactive = true;
        }
        else
        {
            isactive = false;
        }
    }
    void FixedUpdate()
    {
        if (isactive)
        {
            InventoryCanvas.SetActive(true);
        }
        if (!isactive)
        {
            InventoryCanvas.SetActive(false);
        }
    }
}
