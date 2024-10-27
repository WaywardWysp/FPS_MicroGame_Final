using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject KeyCam;
    public GameObject MainCamera;
  

    void update ()
    {
          if (Input.GetKeyDown("f"))
        {
            KeyCam.SetActive(true);
            MainCamera.SetActive(false);
          
        }
         if (Input.GetKeyUp("f"))
        {
            KeyCam.SetActive(false);
            MainCamera.SetActive(true);
         
        }
    }


}
