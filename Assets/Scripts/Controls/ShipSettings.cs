using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Ships/ShipSettings", order = 1)]
public class ShipSettings : ScriptableObject
{
    
    [SerializeField] private float moveSpeed = 5f;
    public float MoveSpeed => moveSpeed;
}
