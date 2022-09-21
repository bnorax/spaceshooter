using UnityEngine;

public class ShipMotor
{
    private readonly IShipInput _shipInput;
    private readonly Transform _transform;
    private Transform _spriteObjectTransform;
    private readonly ShipSettings _shipSettings;
    private Vector3 _rotation;
    //private readonl
    public ShipMotor(IShipInput shipInput, Transform transform, ShipSettings shipSettings)
    {
        _shipInput = shipInput;
        _transform = transform;
        _shipSettings = shipSettings;
        _spriteObjectTransform = _transform.GetChild(0);
    }

    public void Tick()
    {
        //_transform.Rotate(Time.deltaTime*_shipInput.*Vector2.up);
        _transform.position += _shipInput.Direction*(Time.deltaTime*_shipSettings.MoveSpeed);
        if (_shipSettings.Wiggle)
            Wiggle();
        else
            _rotation.Set(0, 180f, 0);
        _spriteObjectTransform.rotation = Quaternion.Euler(_rotation);
    }
    
    private void Wiggle()
    {
        _spriteObjectTransform.Rotate(0f, _shipInput.Rotation.y, 0f);
        _rotation.y = Mathf.Clamp(_spriteObjectTransform.eulerAngles.y, 180f-_shipSettings.WiggleBoundaries, 180f+_shipSettings.WiggleBoundaries);
    }
}
