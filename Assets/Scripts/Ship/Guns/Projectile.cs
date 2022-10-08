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
        col.gameObject.SetActive(false);
        Debug.Log("dsa");
    }

    private void Update()
    {
        transform.Translate(0, speed*Time.deltaTime, 0);
    }
}
