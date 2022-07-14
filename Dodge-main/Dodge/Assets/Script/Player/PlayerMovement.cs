using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _input;
    Rigidbody _rb;
    private float speed = 8f;
    void Start()
    {
        _input = GetComponent<PlayerInput>();
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = _input.X * speed * Time.deltaTime;
        float zSpeed = _input.Y * speed * Time.deltaTime;

        gameObject.transform.Translate(xSpeed, 0 , zSpeed);
    }
}
