using UnityEngine;

public interface IShipInput
{
    void ReadInput();
    bool Fire();
    Vector3 Direction { get; }
    // Basically this is where our ship wants to be rotated
    Vector3 TargetRotation { get; }
}
