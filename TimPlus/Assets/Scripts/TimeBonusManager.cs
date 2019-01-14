using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBonusManager : MonoBehaviour {
    public GameObject _TimeBonusObject;
    public Transform[] _SpawnPositions;
    private GameObject clone;
    // Use this for initialization
    void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void SpawnBonus() {
        int index = Random.Range(0, _SpawnPositions.Length);
        clone = Instantiate(_TimeBonusObject, _SpawnPositions[index].position, _SpawnPositions[index].rotation);

    }
    public void KillBonus() {
        Destroy(clone);
    }
}
