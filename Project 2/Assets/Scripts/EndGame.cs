using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Application.Quit();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
