using System;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 0f;
    private void Awake()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject target;
        (target = col.gameObject).SetActive(false);
        Destroy(target);
        GameObject projectile;
        (projectile = this.gameObject).SetActive(false);
        Destroy(projectile);
        Debug.Log("dsa");
    }

    private void Update()
    {
        transform.Translate(0, speed*Time.deltaTime, 0);
    }
}
