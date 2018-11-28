using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideToggle : MonoBehaviour {

    bool showing = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void whenClicked()
    {
        if (showing)
        {
            this.gameObject.GetComponent<Renderer>().enabled = false;
            showing = false;
        } else if (!showing)
        {
            this.gameObject.GetComponent<Renderer>().enabled = true;
            showing = true;
        }
    }
}
