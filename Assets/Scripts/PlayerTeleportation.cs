using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleportation : MonoBehaviour
{
    private GameObject currentTeleporter;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T)){
            if(currentTeleporter!=null){
                transform.position = currentTeleporter.GetComponent<Teleport>().GetDestination().position;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Teleporters")){
            currentTeleporter = other.gameObject;
        }
    }

   /* private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Teleporters")){
            if(other.gameObject == currentTeleporter){
                currentTeleporter = null;
            }
        }
    }*/
}
