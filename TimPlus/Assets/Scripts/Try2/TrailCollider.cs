using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailCollider : MonoBehaviour {
    public TargetManager _TargetManager;
    public bool _cangiverror=false;
    public int _colliderlife=40;
    public int _activationdelay = 1;
	// Use this for initialization
	void Awake () {
        _TargetManager = GameObject.FindWithTag("Manager").GetComponent<TargetManager>();
        StartCoroutine(Example());
       // StartCoroutine(WaitForDissappear());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other) {
        //error de trail
        if (other.gameObject.tag == "TrailFinger"&&_cangiverror)
        {

            _TargetManager.AddTrailError();
        }
    }  

IEnumerator Example()
{
   
    yield return new WaitForSeconds(_activationdelay);
        _cangiverror = true;
        yield return new WaitForSeconds(_colliderlife);
        Destroy(transform.gameObject);
    }
IEnumerator WaitForDissappear()
    {

        yield return new WaitForSeconds(_colliderlife);
        Destroy(transform.gameObject);
    }
}
