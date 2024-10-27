using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter(Collider Player)
    {
        anim.SetTrigger("PlayerProximity");
    }

    private void OnTriggerExit(Collider Player)
    {
        anim.SetTrigger("PlayerProximityExit");
    }
}
