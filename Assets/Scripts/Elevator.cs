using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public Transform player;
    public Transform elevatorSwitch;
    public Transform downPos;
    public Transform upPos;
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
        if(Vector2.Distance(player.position,elevatorSwitch.position)<1f&&Input.GetKey(KeyCode.E)){
            if(transform.position.y<=downPos.position.y){
                isElevatorDown = true;
            }else if(transform.position.y>=upPos.position.y){
                isElevatorDown = false;
            }
        }

        if(isElevatorDown){
            transform.position = Vector2.MoveTowards(transform.position,upPos.position,speed*Time.deltaTime);
        }else{
            transform.position = Vector2.MoveTowards(transform.position,downPos.position,speed*Time.deltaTime);
        }
    }
}
