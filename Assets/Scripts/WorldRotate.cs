using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldRotate : MonoBehaviour
{
    public Transform rotateWorld;

    public Vector3 rotation = new Vector3(180,0,0);

    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            rotateWorld.Rotate(rotation);
        }    
    }
}
