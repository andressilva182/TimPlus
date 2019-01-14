using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TargetManager : MonoBehaviour {
    public Text _CorrectPoints;
    public Text _Errors;
    public Text _Corrections;
    public Text _OrderError;
    public int _SuccessAmount;
    public int _ErrorAmount;
    public int _CorrectionAmount;
    public int _OrderErrorAmount;
    public TargetTimeManager _TimeManager;
    public Text _TriesText;
    public int _Tries = 1;
    public GameObject _PatternSpawnPoint;
    public GameObject _PatternPrefab;
    public GameObject _CurrentPattern;
    public GameObject _NextStageUI;
    public MiscInformation _Misc;
    public int _TrailError=0;
    public Text _TrailErrorText;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        _CorrectPoints.text = "" + _SuccessAmount;
        _Errors.text = "" + _ErrorAmount;
        _Corrections.text = "" + _CorrectionAmount;
        _OrderError.text = "" + _OrderErrorAmount;
    }
    public void ChangePattern() {
        _TimeManager.FinishedPattern();
        Debug.Log("NEW PATTERN");
        _NextStageUI.SetActive(true);
    }
    public void AddError() {
        _ErrorAmount += 1;
    }
    public void AddSuccess() {
        _SuccessAmount += 1;
    }
    public void AddCorrection() {
        _CorrectionAmount+=1;
        _OrderErrorAmount -= 1;
    }
    public void AddOrderError()
    {
        _OrderErrorAmount += 1;
    }

    public void AddTrailError() {
        _TrailError += 1;
        _TrailErrorText.text = ""+_TrailError;

    }

    public void SoftReset()
    {
        _NextStageUI.SetActive(false);
        SpawnPattern();
        _Tries += 1;
        _TriesText.text = "" + _Tries;
        _Misc._AmountErrors -= 1;
        _TimeManager.hasFinished = false;



    }

  

    public void HardReset() {

        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

    public void SpawnPattern() {
        GameObject[] patterns = GameObject.FindGameObjectsWithTag("Pattern");
        foreach (GameObject pat in patterns) {
            Destroy(pat);

        }
       
        _CurrentPattern = Instantiate(_PatternPrefab, _PatternSpawnPoint.transform.position, _PatternSpawnPoint.transform.rotation);
    }

}
