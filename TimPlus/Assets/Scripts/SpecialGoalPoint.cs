using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialGoalPoint : MonoBehaviour {
    public float _TimeBonus;
    public TimeManager _TimeManager;
    // Use this for initialization
    void Start () {
        _TimeManager = GameObject.FindWithTag("GoalPointManager").GetComponent<TimeManager>(); //CHANGE IF THE OBJECT IS NOT THE SAME AS THE GOAL POINT MANAGER
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "TrailPlayer")
        {
            if (_TimeManager._CurrentTime- _TimeBonus <= 0) {

                _TimeManager._CurrentTime = 0;

            } else {

              
                _TimeManager._CurrentTime -= _TimeBonus;
            }
            //    _GoalPattern.CheckPoints();
            Destroy(transform.gameObject);
        }

    }
}
