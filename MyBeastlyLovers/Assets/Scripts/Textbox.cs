using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textbox : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetTextBoxActive()
    {
        gameObject.SetActive(true);
    }
    public void SetTextBoxInactive()
    {
        gameObject.SetActive(false);
    }
}
