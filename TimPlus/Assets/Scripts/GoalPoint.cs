using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPoint : MonoBehaviour {
   // public Pattern _GoalPattern;
    public GoalPointManager _Manager;
    public Pattern _Pattern;
    public bool _Active=false;
	// Use this for initialization
	void Start () {
        _Manager = GameObject.FindWithTag("GoalPointManager").GetComponent<GoalPointManager>();
        if (_Manager._SequenceMode) {
            //Spawn in order
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider col) {

        if (col.gameObject.tag == "TrailFinger"&&_Active){
            _Manager.ReduceCurrentPoints();
            _Pattern.NextPoint();
        //    _GoalPattern.CheckPoints();
            Destroy(transform.gameObject);
        }

    }
}
