using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
    //public GameObject controllerObject;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    controllerObject.SetActive(true);
    //}

    public GameObject KeyCam;
    public GameObject WeaponCam;



    private void OnTriggerEnter(Collider Player)
    {
        KeyCam.SetActive(true);
        WeaponCam.SetActive(false);
    }

    private void OnTriggerExit(Collider Player)
    {
        KeyCam.SetActive(false);
        WeaponCam.SetActive(true);
    }
}
