using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFollowMouse : MonoBehaviour {

    private GameObject wayPoint;
    private Vector3 wayPointPos;
    
    private float speed = 6.0f;
    void Start()
    {
        //At the start of the game, the object will find the gameobject called wayPoint.
        wayPoint = GameObject.Find("wayPoint");
    }

    void Update()
    {
        wayPointPos = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
        
        transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
    }
}
