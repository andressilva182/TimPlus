using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimAnimations : MonoBehaviour {

    private Animator anim;

    void Start () {
        anim = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(0))
        {
            anim.Play("Run");
            anim.SetBool("isRun", true);
            anim.SetBool("isIdle", false);
        }
        else
        {
            anim.SetBool("isRun", false);
            anim.SetBool("isIdle", true);
        }
    }

}

