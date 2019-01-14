using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Camera cam = Camera.main;

        float pos = (cam.nearClipPlane + 10.0f);

        transform.position = cam.transform.position + cam.transform.forward * pos;
        transform.LookAt(cam.transform);
        transform.Rotate(90.0f, 0.0f, 0.0f);

        transform.localScale = new Vector3(cam.orthographicSize * (Screen.width / Screen.height), 0.1f, cam.orthographicSize);

        Debug.Log(Screen.width);
        Debug.Log(Screen.height);
        Debug.Log((double)(Screen.width / Screen.height));

      //  float h = (Mathf.Tan(cam.fieldOfView * Mathf.Deg2Rad * 0.5f) * pos * 2f) / 10.0f;

        //transform.localScale = new Vector3(h * cam.aspect, 1.0f, h);
    }
}
