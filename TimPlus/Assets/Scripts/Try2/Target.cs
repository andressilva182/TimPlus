using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
    public SmallRadius _SmallRadius;
    public BigRadius _BigRadius;
    public TargetPattern _Pattern;
    public TargetManager _Manager;
    public int TargetNumber; //Número en la secuencia
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void DetectSmall() {
     

        bool scored = _Pattern.CheckIfPointScored(TargetNumber,_SmallRadius,_BigRadius);
       

    }
    public void ScorePoint1() {
        //CASE 1 : FINGER TOUCHED CENTER OF POINT
      //  _SmallRadius.gameObject.SetActive(false);
    }
    public void ScorePoint2()
    {
        //CASE 2 : FINGER ONLY TOUCHED BIG RADIUS
        
    }
    public void DetectBig()
    {
     

        bool scored = _Pattern.CheckIfError(TargetNumber,_SmallRadius);

    
    }
    public void DetectError() {
        bool scored = _Pattern.CheckIfCorrected(TargetNumber-1, _SmallRadius);
    }
}
