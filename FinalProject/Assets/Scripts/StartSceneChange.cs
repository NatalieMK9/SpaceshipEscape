using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        //2
        if (other.name == "DebitCard")
        {
            SceneManager.LoadScene("vrfinalspace", LoadSceneMode.Additive);
        }
    }
}
