using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Ships/ShipSettings", order = 1)]
public class ShipSettings : ScriptableObject
{
    [SerializeField] private bool enemy;
    [SerializeField] private bool shoot;
    [SerializeField] private float projectileSpeed = 10f;
    [SerializeField] private bool spawn;
    [SerializeField] private bool wiggle;
    [SerializeField] private float wiggleBoundaries = 270f;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float boundary = 2f;
    public bool Enemy => enemy; 
    public bool Shoot => shoot;
    public float ProjectileSpeed
    {
        get => projectileSpeed;
        set => projectileSpeed = value;
    }

    public bool Spawn => spawn;
    public bool Wiggle => wiggle;
    public float WiggleBoundaries => wiggleBoundaries;
    public float MoveSpeed => moveSpeed;
    public float Boundary => boundary;
}
