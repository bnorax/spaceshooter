using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Ships/ShipSettings", order = 1)]
public class ShipSettings : ScriptableObject
{
    [SerializeField] private bool enemy;
    [SerializeField] private bool wiggle;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float projectileSpeed = 10f;
    [SerializeField] private float boundary = 2f;
    public bool Enemy => enemy;
    public bool Wiggle => wiggle;
    public float MoveSpeed => moveSpeed;
    public float ProjectileSpeed => projectileSpeed;
    public float Boundary => boundary;
}
