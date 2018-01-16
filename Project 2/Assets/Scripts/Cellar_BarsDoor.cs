using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cellar_BarsDoor : MonoBehaviour {

    Animator animator;
    bool doorOpen;

    private void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();

    }

    private void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "player")
        {
            doorOpen = true;
            Door("Open");
        }
    }

    private void OnTriggerExit(Collider col)
    {

        if (col.gameObject.tag == "player")
        {
            doorOpen = false;
            Door("Close");
        }
    }

    void Door(string direction)
    {
        animator.SetTrigger(direction);
    }

}
