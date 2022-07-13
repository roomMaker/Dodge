using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    void Update()
    {
        
    }
    public void Die()
    {
        // 게임 오브젝트를 삭제
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        {
            Die();
            FindObjectOfType<GameManager>().End();
        }
    }

}
