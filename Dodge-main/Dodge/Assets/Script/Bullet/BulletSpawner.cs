using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    
    public Transform Player;
    public bool isTarget {get; private set;}
    void Start()
    {
        isTarget = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isTarget)
        {
            gameObject.transform.LookAt(Player);
        }
        gameObject.transform.Rotate(0, 0.3f, 0);
    }

    
    private void OnTriggerStay(Collider other)
    {
        isTarget = true;
    }
    private void OnTriggerExit(Collider other)
    {
        isTarget = false;
    }
}
