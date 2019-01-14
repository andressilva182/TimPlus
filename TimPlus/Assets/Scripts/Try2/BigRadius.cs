using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigRadius : MonoBehaviour {
    public Target _Target;
    public Material _Off;
    public Material _On;
    public bool HasSucceeded=false;
    private Renderer rend;
    public bool CanBeCorrected = false;
    // Use this for initialization
    void Start () {
       rend = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider Col) {
        if (Col.gameObject.tag.Equals("TrailFinger")) {
            if (CanBeCorrected)
            {
                Debug.Log("CORRECTED");
                _Target.DetectError();
                CanBeCorrected = false;
            }
            rend.material = _On;
           // _Target.DetectBig();
        }

    }
    void OnTriggerExit(Collider Col)
    {
        if (Col.gameObject.tag.Equals("TrailFinger"))
        {
            rend.material = _Off;
            if (HasSucceeded == false)
            {
                _Target.DetectBig();

            }
            
        }

    }
}
