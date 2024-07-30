using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bulletScript : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
       [SerializeField] float loadDelay = 0f;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       rb.velocity = -transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag== "Player"){
            Invoke("ReloadScene",loadDelay);
        }
    }

    void ReloadScene(){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
