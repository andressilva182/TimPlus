using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallRadius : MonoBehaviour {
    public Target _Target;
    public Material _Off;
    public Material _On;
    private Renderer rend;
    public bool WasActivated=false;
    public bool CanBeCorrected = false;
    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag.Equals("TrailFinger"))
        {
            _Target.DetectSmall();
            TurnOn();
            if (CanBeCorrected) {
                Debug.Log("CORRECTED");
                _Target.DetectError();
                CanBeCorrected = false;
            }
        }


    }
    void OnTriggerExit(Collider Col)
    {
        if (Col.gameObject.tag.Equals("TrailFinger"))
        {
            _Target.DetectSmall();
            TurnOff();
        }

    }
    public void TurnOn() {
        rend.material = _On;
        WasActivated = true;
    }
    public void TurnOff()
    {
        
        rend.material = _Off;
    }
}
