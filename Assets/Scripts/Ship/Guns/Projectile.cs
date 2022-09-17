using System;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 0f;
    private void Awake()
    {
        
    }

    private void Update()
    {
        transform.Translate(0, speed*Time.deltaTime, 0);
    }
}
