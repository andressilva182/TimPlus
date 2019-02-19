using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIToggleManager : MonoBehaviour {
    private Toggle thisobject;
	// Use this for initialization
	void Start () {
        thisobject = transform.gameObject.GetComponent<Toggle>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OptionChanged(Toggle OtherOption) {
        OtherOption.isOn = !thisobject.isOn;

    }
}
