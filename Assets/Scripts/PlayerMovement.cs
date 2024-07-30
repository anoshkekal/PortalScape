using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float runSpeed =15f;
    [SerializeField] float jumpSpeed = 5f;
    // Start is called before the first frame update
    Vector2 moveInput;
    Rigidbody2D myrigidbody;
    BoxCollider2D myBoxCollider;
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        myBoxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        FlipSprite();
        SwitchGravity();
    }

    void OnMove(InputValue value){
        moveInput = value.Get<Vector2>();
    }

    void OnJump(InputValue value){
        if(!myBoxCollider.IsTouchingLayers(LayerMask.GetMask("Ground"))){
            return;
        }
        if(value.isPressed){
            myrigidbody.velocity += new Vector2(0f,jumpSpeed);
        }
    }

    void Run(){
        Vector2 playerVelocity = new Vector2(moveInput.x * runSpeed,myrigidbody.velocity.y);
        myrigidbody.velocity = playerVelocity;
    }
    void FlipSprite(){
        bool playerHasHorizontalSpeed = Mathf.Abs(myrigidbody.velocity.x)>Mathf.Epsilon;
        if(playerHasHorizontalSpeed){
            transform.localScale = new Vector2(0.1f*Mathf.Sign(myrigidbody.velocity.x),0.1f);
        }
    }

    void SwitchGravity(){
        if(Input.GetKeyDown(KeyCode.R)&&!myBoxCollider.IsTouchingLayers(LayerMask.GetMask("Ground"))){
            myrigidbody.gravityScale *=-1;
        }
    }
}
