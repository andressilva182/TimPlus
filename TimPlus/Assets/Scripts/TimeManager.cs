using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {
    public Slider _TimeBar;
    public float _CurrentTime;
    public float _TimeLimit;
    public float _LiftPenalization;
    public GameObject _GameOverUI;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        _CurrentTime += Time.deltaTime;
      //  Debug.Log(_CurrentTime);
        _TimeBar.value = (1-(_CurrentTime / _TimeLimit));
        if (_CurrentTime >= _TimeLimit) {
            GameOver();

        }
        if (Input.GetTouch(0).phase == TouchPhase.Ended) {
           // Debug.Log("Lift");
            _CurrentTime += _LiftPenalization;
        }
	}
   
    public void GameOver() {
        _GameOverUI.SetActive(true);
            Debug.Log("GAME OVER");

        
    }
}
