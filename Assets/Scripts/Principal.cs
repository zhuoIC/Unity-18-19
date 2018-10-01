using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Principal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SceneInit4()
    {
        
        SceneManager.LoadScene(transform.tag);
    }

    public void Salir()
    {
        if (GUI.Button(new Rect(Screen.height/2, Screen.width/2, 50, 50), "YES"))
        {
            Application.Quit();
        }
        
    }
}
