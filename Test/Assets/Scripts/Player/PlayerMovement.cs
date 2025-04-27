using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem.Composites;

[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{
   private PlayerInputActions playerInputActions;
   private CharacterController characterController;

   [SerializeField] private Vector3 moveDirection;
   [SerializeField] private float speed = 100.1f;
   [SerializeField] private float gravityScale = 9.81f;   
   [SerializeField] private float jumpForce = 5.1f;
   private float verticalVelocity;

   private Vector2 moveInput;

    private void Awake()
    {
       playerInputActions = new PlayerInputActions();

       playerInputActions.Player.Jump.performed += context => JumpHandler();

       playerInputActions.Player.Move.performed += context => moveInput = context.ReadValue<Vector2
    >(); 
        playerInputActions.Player.Move.canceled += context => moveInput = Vector2.zero;
    }

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        moveDirection = new Vector3(moveInput.x, verticalVelocity, moveInput.y);

        if (moveDirection.magnitude > 0) {
            characterController.Move(speed * Time.fixedDeltaTime * moveDirection);
        }

        Gravity();
    }

    private void Gravity(){
        if (characterController.isGrounded){
            verticalVelocity = -0.5f;
        }
        else {
            verticalVelocity -= gravityScale * Time.fixedDeltaTime;
        }
    }
    private void JumpHandler(){
        if (characterController.isGrounded) {
            verticalVelocity = jumpForce;
        }
    }
    
    void OnEnable()
    {
        playerInputActions.Enable();
    }

    void OnDisable()
    {
        playerInputActions.Disable();
    }

}
