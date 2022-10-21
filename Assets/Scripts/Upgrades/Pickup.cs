using UnityEngine;

public class Pickup : Projectile
{
    [SerializeField] private ShipGuns _ship;
    public void Spawn()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject != _ship.gameObject) return;
        GameObject projectile;
        (projectile = this.gameObject).SetActive(false);
        Destroy(projectile);
        _ship.projectileSpeed*= 2;
    }
}
