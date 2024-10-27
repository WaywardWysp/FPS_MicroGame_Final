using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public GameObject KeyCam;
    public GameObject PlayerCam;

    void update ()
    {
        if (Input.GetKeyDown(KeyCode.E))
        { 
            KeyCam.SetActive(true);
            PlayerCam.SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.E))
        {  
            KeyCam.SetActive(false);
            PlayerCam.SetActive(true);
        }
    }
}
