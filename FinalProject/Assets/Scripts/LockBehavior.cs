﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockBehavior : MonoBehaviour
{
    public GameObject DebitCard;
    public GameObject card;
    // 1
    void OnTriggerEnter(Collider other)
    {
        //2
        if (other.name == "redkey")
        {
            Debug.Log("Key has been put in lock");
            CreateDebitCard();
            card.transform.localScale = new Vector3(7.94f, 1.413f, 6.843f);
        }
    }
    public void CreateDebitCard()
    {
        card = Instantiate(DebitCard);
    }
    /*
    void OnTriggerExit(Collider other)
    {
        // 4
        if (other.name == "Player")
        {
            Debug.Log("Player out of range, resume patrol");
        }
    }*/
}