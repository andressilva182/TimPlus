using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : MonoBehaviour {
    public GameObject[] _Targets;
    public GameObject[] _Positions;
    public List<int> positionstaken;
    // Use this for initialization
    void Start () {
        foreach (GameObject Target in _Targets) {
            
            int r = Random.Range(0, _Targets.Length);
            while(positionstaken.Contains(r)) {
              r = Random.Range(0, _Targets.Length);
            }
            positionstaken.Add(r);
            Target.transform.position = _Positions[r].transform.position;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
