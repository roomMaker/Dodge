using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    
    public Transform Player;
    public bool isTarget {get; private set;}
    public bool canShot { get; private set; }

    private float _dot;
    private float _angle;
    private Vector3 _cross;

    Vector3 _myVec;
    void Start()
    {
        _myVec = transform.forward;
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 targetDir = Player.position - transform.position;

        _angle = Vector3.Angle(targetDir, _myVec);

        _dot = Vector3.Dot(targetDir, _myVec);

        _cross = Vector3.Cross(targetDir, _myVec);

        if (isTarget && IsPlayerFront(_dot) && IsAngleSixty(_cross) && _angle > 30)
        {
            gameObject.transform.LookAt(Player);
            canShot = true;
        }
        else
        {
            canShot = false;
        }
        //gameObject.transform.Rotate(0, 0.3f, 0);
    }

    
    private void OnTriggerStay(Collider other)
    {
        isTarget = true;
    }
    private void OnTriggerExit(Collider other)
    {
        isTarget = false;
    }

    private bool IsAngleSixty(Vector3 vec)
    {
         if(vec.y > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private bool IsPlayerFront(float fl)
    {
        if(fl > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
