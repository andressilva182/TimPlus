using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern : MonoBehaviour {
    public GoalPoint[] _Points;
    public int _PointAmount; //When spawned, how many points to create//DEFAULT = 4
    public int _MaxPatternPoints; //Limit for this particular pattern 
    public GoalPointManager _Manager;
    private int ind = 0;
    // Use this for initialization
    void Start () {
        CheckPoints();
        _Manager = GameObject.FindWithTag("GoalPointManager").GetComponent<GoalPointManager>();
        if (_Manager._SequenceMode)
        {
            //Spawn in order
            foreach (GoalPoint p in _Points) {
                p.gameObject.SetActive(false);
            }
            _Points[0].gameObject.SetActive(true);

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void SpawnPattern() {
        if (_PointAmount >= _MaxPatternPoints)
        {
            //Solves any problems when the maximum point amount between different patterns varies.
            _PointAmount = _MaxPatternPoints;

        }
    }
    public void NextPoint() {
        ind += 1;
        _Points[ind].gameObject.SetActive(true);

    }

    public void CheckPoints() {
        //Function to check if player has finished the pattern
        int index = 0;
        
        foreach (GoalPoint point in _Points) {
            if (index >= _PointAmount)
            {
                Destroy(point.gameObject);
            }
            else {
                point._Active = true;
            }
            index += 1;
        }
        //System.Array.Resize(ref _Points, _PointAmount);
    }
}
