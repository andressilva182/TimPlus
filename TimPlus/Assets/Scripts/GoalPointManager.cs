using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalPointManager : MonoBehaviour {
    public int _CurrentPoints = 4;  //Current goal points that are left in scene
    public int _TargetPoints = 4;    //Points available in the current stage
    public int _CurrentStage;    //Current Pattern Stage
    public int _StagesBetweenChange = 3; //After how many stages do we increase the number of targets?
    public int _MaxPoints = 20;     //Maximum points that can be displayed
    public Pattern[] _PatternPool;  //Pattern prefabs that can be used
    public Transform _SpawnPoint;
    public TimeBonusManager _TBManager;
    public Text _UIText;
    public int _StageWhenBonusStartsSpawning;
    public int _StageWhenBonusStopsSpawning;
    public bool _SequenceMode; //If true, goal points will spawn in a sequence to follow

    private int stgindex;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ReduceCurrentPoints() {
        _CurrentPoints -= 1;
        if (_CurrentPoints <= 0) {
            ChangePattern();
        }
    }
    public void ChangePattern()
    {
        if (stgindex>=_StagesBetweenChange)
        {
            stgindex = 0;
            //INCREASE POINTS
             _TargetPoints += 1;


        }

        if (_CurrentStage >= _StageWhenBonusStartsSpawning-1 && _CurrentStage <= _StageWhenBonusStopsSpawning-1)
        {
            //SPAWN BONUS 
            _TBManager.KillBonus();
            _TBManager.SpawnBonus();

        }

        _CurrentPoints = _TargetPoints;
        Debug.Log("SPAWNED NEW LETTER");
        //CHOOSE LETTER

        int choice = Random.Range(0, _PatternPool.Length);
        //SPAWN NEW LETTER
        Pattern pattern = (Pattern)Instantiate(_PatternPool[choice], _SpawnPoint.position, _SpawnPoint.rotation);
        pattern._PointAmount = _TargetPoints;
        stgindex += 1;
        _CurrentStage += 1;
        _UIText.text = "" + _CurrentStage;

    }
    
}
