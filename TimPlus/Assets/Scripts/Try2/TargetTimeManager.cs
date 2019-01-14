using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TargetTimeManager : MonoBehaviour {
    public Text _Timer;
    public static float timer;
    public int _initialMinutes;
    public int _initialSeconds;
    public bool countdown;
    public bool hasstarted=false;
    public GameObject _startScreen;
    public Text _StartCountdown;
    public float countdownamount = 6f;
    public bool startcountdown = false;
    public GameObject _countdownScreen;
    public SwipeTrail _Player;
    public bool hasFinished = false;
    public GameObject _TutorialScreen;
    public GameObject _CountdownNumber;
  
    public void StartTime() {  //START COUNTDOWN
        _TutorialScreen.SetActive(false);
        _startScreen.SetActive(false);
        startcountdown = true;
        _CountdownNumber.SetActive(true);
    }

    public void ShowTutorial() {
        _TutorialScreen.SetActive(true);
    }

	// Use this for initialization
	void Start () {
        timer = _initialMinutes*60+_initialSeconds;
        Debug.Log(_initialMinutes * 60 + _initialSeconds);
      

    }
	public void FinishedPattern()
    {
        //_Timer.gameObject.SetActive(false);
        //PAUSE TIMER
        hasFinished = true;
    }
	// Update is called once per frame
	void Update () {

        if (startcountdown) {
            _StartCountdown.text = ""+ (int)countdownamount;
            countdownamount -= Time.deltaTime;

        }
        if (countdownamount <= 0.9f && startcountdown) {
            //GAME STARTS ******
            _Player.StartGame();
            hasstarted = true;
            _countdownScreen.SetActive(false);
            startcountdown = false;
        }



        if (hasstarted && !hasFinished) { 
        if (countdown)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            timer += Time.deltaTime;
           
        }
        

            string minutes = Mathf.Floor(timer / 59).ToString("00");
            string seconds = (timer % 59).ToString("00");
            _Timer.text = string.Format("{0}:{1}", minutes, seconds);

        }


    }


   
   
}
