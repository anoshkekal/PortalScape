using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneReload : MonoBehaviour
{
   [SerializeField] float loadDelay = 2f;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag== "Player"){
            Invoke("ReloadScene",loadDelay);
        }    
    }

    void ReloadScene(){
         int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
