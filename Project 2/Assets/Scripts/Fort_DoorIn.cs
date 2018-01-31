using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fort_DoorIn : MonoBehaviour {

    Animator animator;
    bool doorOpen;

    void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();

    }

    private void OnTriggerStay(Collider col)
    {

        if (col.gameObject.tag == "Player" && doorOpen == false)
        {
            doorOpen = true;
            DoorControl("Open");
            print("doei");
        }
    }

    private void OnTriggerExit(Collider col)
    {

        if (doorOpen && doorOpen == true)
        {
            print("hii");
            doorOpen = false;
            DoorControl("Close");
        }
    }

    void DoorControl(string direction)
    {
        animator.SetTrigger(direction);
    }
}
