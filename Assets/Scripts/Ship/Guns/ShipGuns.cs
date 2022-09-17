using System;
using Unity.VisualScripting;
using UnityEngine;

public class ShipGuns : MonoBehaviour
{
    [SerializeField]private ShipSettings shipSettings;
    [SerializeField] private GameObject[] shipGuns;
    [SerializeField] private GameObject shotPrefab;

    private void Awake()
    {
        
    }

    public void Fire()
    {
        foreach (var gun in shipGuns)
        {
            
            var shot = Instantiate(shotPrefab, gun.transform.position, gun.transform.rotation);
            
            var projectile = shot.GetComponent<Projectile>();
            if (projectile)
                projectile.speed =
                    shipSettings.Enemy ? shipSettings.ProjectileSpeed * -1 : shipSettings.ProjectileSpeed;
            // if(!projectile) projectile.speed = shipSettings.ProjectileSpeed;
        }
    }
}
