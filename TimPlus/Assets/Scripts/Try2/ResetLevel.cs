using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour {

    public TargetManager _TargetManager;

    //SOFT RESET:
    //INICIA NUEVA PARTIDA AGREGANDO A LO QUE YA SE JUGÓ

    //HARD RESET:
    //RESETEA TODO


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Reset() {
     
        _TargetManager.HardReset();
       

    }
    public void SoftReset() {

        _TargetManager.SoftReset();
    }
}
