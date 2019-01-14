using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTrail : MonoBehaviour {

    bool firstTouch = false;
    //private GameObject wayPoint;
    private Vector3 wayPointPos;
    public GameObject Character;
    public GameObject Aim;
 
    private float dist;
    public float OffsetHeight = 12.0f;
    public float speed = 20.0f;//default=20

    private float counter = 6;
    private float timer = 0;
    public GameObject Coins;
    public bool GameStarted=false;
    public int _Counter;
    public int _Rate=25;


    public GameObject _TrailCollider;

    public void StartGame() {
        GameStarted = true;

    }
    // Use this for initialization
    void Start () {
        gameObject.GetComponent<TrailRenderer>().enabled = false;

        //At the start of the game, the object will find the gameobject called wayPoint.
        //wayPoint = GameObject.Find("wayPoint");
    }
	
	// Update is called once per frame
	void Update () {
        if (GameStarted) { 
       // Debug.Log(timer);
        //Debug.Log(counter);

        if (counter < 0)
        {
            timer += Time.deltaTime;
            
            if (timer > 1.5f) {
                Instantiate(Coins, new Vector3(-0.2f, 4.93f, -14.40686f), Quaternion.identity);
                counter = 6;
                timer = 0;
            }
        }


            if (((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0)))
            {
                _Counter += 1;
                if (_Counter % _Rate == 0) {
                    //spawn collider
                    GameObject col = Instantiate(_TrailCollider, Aim.transform.position, Aim.transform.rotation);
                }
                if (firstTouch == false)
                {
                    gameObject.GetComponent<TrailRenderer>().enabled = true;
                    firstTouch = true;

                }

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                RaycastHit hit;


                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.gameObject.tag == "drawPlane") {
                    this.transform.position = hit.point;
                    }
                    //Debug.Log(hit.point.x);
                    // OffsetHeight = 12.0f+ hit.point.x/4;
                    //if 3 -> 8
                    //if 16 -> 17
                    //X matters
                }

                if (hit.collider.tag == "Coin")
                {
                    Destroy(hit.collider.gameObject);
                    counter--;
                }
            }
           


        if(firstTouch == true)
        {
            wayPointPos = new Vector3(transform.position.x+ OffsetHeight, Character.transform.position.y, transform.position.z);
            Aim.transform.position = wayPointPos;
            dist = Vector3.Distance(wayPointPos, Character.transform.position);

            if(dist > 0.2f)
            {
                
                //Character.transform.LookAt(wayPointPos);
            }
           
            Character.transform.position = Vector3.MoveTowards(Character.transform.position, wayPointPos, speed * Time.deltaTime);
        }
		
	}
    }
}
