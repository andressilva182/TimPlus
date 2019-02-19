using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIPageWithRedirects : MonoBehaviour {
    public int lastpage;
    public Text UIText;
    public UI_ButtonInfo BackButton;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        UIText.text = "" + lastpage;
        BackButton.index = lastpage;
       
        
	}
}
