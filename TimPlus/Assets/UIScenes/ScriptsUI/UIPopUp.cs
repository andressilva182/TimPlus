using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPopUp : MonoBehaviour {
    public GameObject UIWindow;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ShowPopUp() {
        UIWindow.SetActive(true);


    }
    public void HidePopUp()
    {
        UIWindow.SetActive(false);

    }
}
