using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PewLock : MonoBehaviour
{
    public GameObject PewPew;
    public GameObject pew;
    // 1
    void OnTriggerEnter(Collider other)
    {
        //2
        if (other.name == "bluekey")
        {
            Debug.Log("The PewPew has been summoned");
            CreateDebitCard();
            pew.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            pew.transform.position = new Vector3(12.116f, 2.136f, -4.628f);
        }
    }
    public void CreateDebitCard()
    {
        pew = Instantiate(PewPew);
    }
}
