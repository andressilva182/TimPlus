using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPattern : MonoBehaviour {
    public int _InitialAmount;
    public int _CurrentAmount; //Amount of points on screen
    public int _CurrentNumber=1; //Number in the sequence (order)
    public TargetManager _TargetManager;
    public int _NumberTouched;
	// Use this for initialization
	void Awake () {
        _TargetManager = GameObject.FindWithTag("Manager").GetComponent<TargetManager>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public bool CheckIfPointScored(int num, SmallRadius pointcenter, BigRadius radius){
        _NumberTouched = num;
       // Debug.Log("nm: "+num);
      //  Debug.Log("cn: "+_CurrentNumber);
      //  Debug.Log(num == _CurrentNumber);
        radius.HasSucceeded = true;
        if (num == _CurrentNumber)
        {
            Debug.Log("SCORED");
            _CurrentNumber += 1;
            _CurrentAmount -= 1;
            _TargetManager.AddSuccess();
            pointcenter.TurnOn();
            // pointcenter.gameObject.SetActive(false);
           
            if (_CurrentAmount <= 0)
            {
                this.gameObject.SetActive(false);
                _TargetManager.ChangePattern();
            }
            return true;
        }
        else {
            if (!pointcenter.WasActivated)
            {
                _TargetManager.AddOrderError();

            }
           
            return false;
        }//else: the user went in wrong order

    }
    public bool CheckIfError(int num, SmallRadius pointcenter)
    {
        _NumberTouched = num;
     //   Debug.Log("nm: " + num);
      //  Debug.Log("cn: " + _CurrentNumber);
      //  Debug.Log(num == _CurrentNumber);
        if (num == _CurrentNumber)
        {
            Debug.Log("ERROR");
            _CurrentNumber += 1;
            _CurrentAmount -= 1;
            _TargetManager.AddError();
            pointcenter.CanBeCorrected = true;
            //pointcenter.gameObject.SetActive(false);
            if (_CurrentAmount <= 0)
            {
                this.gameObject.SetActive(false);
                _TargetManager.ChangePattern();
            }
            return true;
        }
        else
        {

            return false;
        }//else: the user went in wrong order

    }

    public bool CheckIfCorrected(int num, SmallRadius pointcenter)
    {
        _TargetManager.AddCorrection();
        return true;
    }
}
