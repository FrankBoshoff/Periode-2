using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cellar_BarsDoor : MonoBehaviour {

    Animator animator;
    bool doorOpen;

    void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();

    }

    private void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Player")
        {
            doorOpen = true;
            DoorControl("Open");
        }
    }

    private void OnTriggerExit(Collider col)
    {

        if (doorOpen)
        {
            doorOpen = false;
            DoorControl("Close");
        }
    }

    void DoorControl(string direction)
    {
        animator.SetTrigger(direction);
    }

}
