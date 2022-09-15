using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ShoeScript : MonoBehaviour
{
    public TextMeshProUGUI ShoeScore;
    public GameObject ThisObj;
    public int shoeNum;
    void Start()
    {
        shoeNum = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        shoeNum++;
        ShoeScore.text = shoeNum.ToString();
        ThisObj.SetActive(false);
    }
}
