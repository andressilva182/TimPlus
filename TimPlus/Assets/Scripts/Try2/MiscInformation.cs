using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiscInformation : MonoBehaviour
{
    public int _AmountErrors = 0; //Finger left the screen
    public TargetTimeManager _TimeManager;
    public Text _FingerErrorText;
    public Text _TouchTimer;
    public static float touchtimer;
    public bool touching=false;
    
    void Start()
    {
        touchtimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        string minutes = Mathf.Floor(touchtimer / 59).ToString("00");
        string seconds = (touchtimer % 59).ToString("00");
        _TouchTimer.text = string.Format("{0}:{1}", minutes, seconds);

        if (_TimeManager.hasstarted && !_TimeManager.hasFinished) {
           
        if(touching)
            {
                touchtimer += Time.deltaTime;
            }
            if (Input.GetMouseButtonUp(0))
            {
                touching = false;
           _AmountErrors += 1;
            _FingerErrorText.text = ""+_AmountErrors;
            Debug.Log(_AmountErrors);
             }
            if (Input.GetMouseButtonDown(0))
            {
                touching = true;
            }
        }
    }
}
