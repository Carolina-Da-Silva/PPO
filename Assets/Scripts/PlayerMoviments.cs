using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerActions playerActions;
    private float speed = 5f;
    private Rigidbody rb;
    private Vector2 moveDirections = Vector2.zero;
    private InputAction move;
    private InputAction jump;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerActions = new PlayerActions();
    }

    private void OnEnable()
    {
        move = playerActions.Player_.Move;
        jump = playerActions.Player_.Jump;
        move.Enable();
        jump.Enable();
    }

    private void OnDisable()
    {
        move.Disable();
        jump.Disable();
    }

    public void setJump()
    {
        print("Jump");
        rb.AddForce(Vector3.up * 100);
    }

    private void Update()
    {
        moveDirections = move.ReadValue<Vector2>();
        transform.position += new Vector3(moveDirections.x, 0, moveDirections.y) * Time.deltaTime * speed;
    }
}
