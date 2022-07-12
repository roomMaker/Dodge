using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _input;
    Rigidbody _rb;
    public float speed = 10f;
    public bool UseSpeed = false;
    // Start is called before the first frame update
    void Start()
    {
        _input = GetComponent<PlayerInput>();
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = _input.X * speed;
        float zSpeed = _input.Y * speed;

        if(UseSpeed)
        {
            _rb.velocity = new Vector3(xSpeed, 0, zSpeed);
        }
        else
        {
            _rb.AddForce(xSpeed, 0 ,zSpeed);
        }
        
    }
}
