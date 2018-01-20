using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour {

    public int state = 1;
    public float range = 4f;
    
    public Camera fpsCam;
	
	// Update is called once per frame
	void Update () {
	
        if(Input.GetButtonDown("Fire1"))
        {
            Interaction();
        }
	}

    void Interaction()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {         
            Handle handle = hit.transform.GetComponent<Handle>();
            if (handle != null)
            {
                handle.OnOff(state);
            }

        }

    }
}