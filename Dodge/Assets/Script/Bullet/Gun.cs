using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float time = 0f;
    public BulletSpawner spawner;

    void Update()
    {
        if(spawner.isTarget)
        {
            Attack();
        }
    }
    void Attack()
    {
        time += Time.deltaTime;
        if (time >= Random.Range(0.5f, 1f))
        {
            time = 0f;
            GameObject bullet = Instantiate(BulletPrefab);
            bullet.transform.position = gameObject.transform.position;
            bullet.transform.LookAt(spawner.Player);
        }
    }
}
