using UnityEngine;

public class ShipMotor
{
    private readonly IShipInput _shipInput;
    private readonly Transform _transform;
    private Transform _spriteObjectTransform;
    private readonly ShipSettings _shipSettings;

    // replace this with serializefield or something
    private Vector3 _defaultAngle = new Vector3(0f, 180f, 0f);
    
    public ShipMotor(IShipInput shipInput, Transform transform, ShipSettings shipSettings)
    {
        _shipInput = shipInput;
        _transform = transform;
        _shipSettings = shipSettings;
        _spriteObjectTransform = _transform.GetChild(0);
    }

    public void Tick()
    {
        _transform.position += _shipInput.Direction*(Time.deltaTime*_shipSettings.MoveSpeed);
        if (_shipSettings.Wiggle)
            Wiggle(_shipInput.TargetRotation);
    }
    
    private void Wiggle(Vector3 rotation)
    {
        // Multiply rotation by Time.deltaTime for framerate independency
        _spriteObjectTransform.rotation = Quaternion.RotateTowards(_spriteObjectTransform.rotation,
            Quaternion.Euler(_defaultAngle + rotation), 60f * Time.deltaTime);
    }
}
