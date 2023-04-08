using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float rotateSpeed = 10f;

    private bool isWalking;

    private void Update()
    {
        Vector2 inputVector = new Vector2();
        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y = 1.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y = -1.0f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1.0f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x = 1.0f;
        }
        inputVector.Normalize();
        Vector3 moveDir = new Vector3(inputVector.x, 0, inputVector.y);
        isWalking = moveDir != Vector3.zero;
        transform.position += moveDir * moveSpeed * Time.deltaTime;
        transform.forward = Vector3.Slerp(transform.forward, moveDir, rotateSpeed * Time.deltaTime);
    }

    public bool IsWalking()
    {
        return isWalking;
    }
}