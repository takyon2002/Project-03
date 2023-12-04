using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _turnSpeed;
    Rigidbody _rb = null;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMove();
        PlayerTurn();
    }
    void PlayerMove()
    {
        float moveFowardThisFrame = Input.GetAxisRaw("Vertical")* _moveSpeed;
        float moveSideThisFrame = Input.GetAxisRaw("Horizontal") * _moveSpeed;

        Vector3 moveForwardDirection = transform.forward * moveFowardThisFrame;
        Vector3 moveSideDirection = transform.right * moveSideThisFrame;

        _rb.AddForce(moveForwardDirection);
        _rb.AddForce(moveSideDirection);

    }
    private void PlayerTurn()
    {

    }
}
