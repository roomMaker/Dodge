using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform Player;
    bool isTarget = false;
    float time = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isTarget)
            Attack();
    }

    void Attack()
    {
        time += Time.deltaTime;
        if (time >= Random.Range(0.5f, 1f))
        {

            time = 0f;
            GameObject bullet = Instantiate(BulletPrefab, transform);
            bullet.transform.LookAt(Player);
        }
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
