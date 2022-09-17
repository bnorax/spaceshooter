using UnityEngine;

public class ShipMotor
{
    private readonly IShipInput _shipInput;
    private readonly Transform _transform;
    private readonly ShipSettings _shipSettings;
    //private readonl
    public ShipMotor(IShipInput shipInput, Transform transform, ShipSettings shipSettings)
    {
        _shipInput = shipInput;
        _transform = transform;
        _shipSettings = shipSettings;
    }

    public void Tick()
    {
        //_transform.Rotate(Time.deltaTime*_shipInput.*Vector2.up);
        _transform.position += _shipInput.Direction*(Time.deltaTime*_shipSettings.MoveSpeed);
        _transform.Rotate(_shipInput.Rotation.x, _shipInput.Rotation.y, 0f);
    }
}
