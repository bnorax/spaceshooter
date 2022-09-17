using UnityEngine;

public interface IShipInput
{
    void ReadInput();
    bool Fire();
    Vector3 Position { get; }
}
