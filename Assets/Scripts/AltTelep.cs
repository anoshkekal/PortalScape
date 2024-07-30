using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltTelep : MonoBehaviour
{
    public Transform destination;
    GameObject player;
    public void Awake(){
        player = GameObject.FindGameObjectWithTag("Player");
    }
   public void OnTriggerEnter2D(Collider2D collision){
    if(Vector2.Distance(player.transform.position,transform.position)>0.5f)
        if(collision.CompareTag("Player")) 
            player.transform.position = destination.transform.position;
   }
}
