using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Principal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Salir()
    {
        if (GUI.Button(new Rect(Screen.height/2, Screen.width/2, 20, 20), "YES"))
        {
            Application.Quit();
        }
        
    }
}
