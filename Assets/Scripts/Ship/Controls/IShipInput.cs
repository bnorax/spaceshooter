using UnityEngine;

public interface IShipInput
{
    void ReadInput();
    bool Fire();
    Vector3 Direction { get; }
    Vector3 Rotation { get; }
}
