/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlat : MonoBehaviour
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
        StartElevator();
    }

    void StartElevator(){
        if(Vector2.Distance(player.position,elevatorSwitch.position)){
            if(transform.position.x<=lefpos.position.x){
                isElevatorDown = true;
            }else if(transform.position.x>=rigpos.position.x){
                isElevatorDown = false;
            }
        }

        if(isElevatorDown){
            transform.position = Vector2.MoveTowards(transform.position,upPos.position,speed*Time.deltaTime);
        }else{
            transform.position = Vector2.MoveTowards(transform.position,downPos.position,speed*Time.deltaTime);
        }
    }
}*/
