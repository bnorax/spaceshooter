using System;
using Unity.VisualScripting;
using UnityEngine;

public class ShipGuns : MonoBehaviour
{
    [SerializeField]private ShipSettings shipSettings;
    [SerializeField] private GameObject[] shipGuns;
    [SerializeField] private GameObject shotPrefab;
    public float projectileSpeed;

    private void Awake()
    {
        projectileSpeed = shipSettings.ProjectileSpeed;
    }

    public void Fire()
    {
        if(!shipSettings.Shoot) return;
        foreach (var gun in shipGuns)
        {
            
            var shot = Instantiate(shotPrefab, gun.transform.position, gun.transform.rotation);
            
            var projectile = shot.GetComponent<Projectile>();
            if (projectile)
                projectile.speed =
                    shipSettings.Enemy ? projectileSpeed * -1 : projectileSpeed;
            // if(!projectile) projectile.speed = shipSettings.ProjectileSpeed;
        }
    }
}
