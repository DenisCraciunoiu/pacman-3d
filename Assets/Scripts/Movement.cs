using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed=1.0f;
    public float Sensitivity = 2.0f;
    public CharacterController controller;
    void Start()
    {
            controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        controller.Move(transform.forward * Speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.A))
            rotateLeft();
        if (Input.GetKeyDown(KeyCode.D))
            rotateRight();
    }
    void rotateLeft()
    {
        transform.rotation *= Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -90, 0), 3.0f);
    }

    void rotateRight()
    {
        transform.rotation *= Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), 3.0f);
    }
}
