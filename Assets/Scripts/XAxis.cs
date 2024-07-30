using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XAxis : MonoBehaviour
{
    //public Transform player;
    //public Transform elevatorSwitch;
    public Transform lefpos;
    public Transform rigpos;
    public float speed=3;
    bool isElevatorDown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartMove();
    }

    void StartMove(){
            if(transform.position.x<=lefpos.position.x){
                isElevatorDown = true;
            }else if(transform.position.x>=rigpos.position.x){
                isElevatorDown = false;
            }

        if(isElevatorDown){
            transform.position = Vector2.MoveTowards(transform.position,rigpos.position,speed*Time.deltaTime);
        }else{
            transform.position = Vector2.MoveTowards(transform.position,lefpos.position,speed*Time.deltaTime);
        }
    }
}
