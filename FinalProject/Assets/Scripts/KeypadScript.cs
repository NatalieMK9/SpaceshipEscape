using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadScript : MonoBehaviour
{
    public GameObject DebitCard;
    public GameObject card;
    public AudioClip DoorOpen;
    // 1
    void OnTriggerEnter(Collider other)
    {
        AudioSource beepbeep = GetComponent<AudioSource>();

        if (other.name == "DebitCard")
        {
            Debug.Log("Key has been tapped on the keypad");
            beepbeep.Play();
        }
    }
}
