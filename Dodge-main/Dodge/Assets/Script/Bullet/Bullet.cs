using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float Speed = 10f;

    void Start()
    {
        Destroy(gameObject, 5f);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, Speed * Time.deltaTime));   
    }

}
