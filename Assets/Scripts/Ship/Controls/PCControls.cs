using Unity.VisualScripting;
using UnityEngine;

public class PCControls : IShipInput
{
    private Vector3 _direction;
    private Transform _transform;
    private ShipSettings _settings;
    
    public PCControls(Transform transform, ShipSettings settings)
    {
        _transform = transform;
        _settings = settings;
    }
    
    public void ReadInput()
    {
        _direction.Set(Input.GetAxis("Horizontal"), 
            Input.GetAxis("Vertical"), 0);
            
        Direction = _direction; //for now? testing
        // So, basically, we set where we want to rotate base on the input axis
        // With joysticks it will also work gradually - rotating it half way will move you at half speed and rotate the ship half the angle
        // The ship also returns at zero rotation if isnt given any input, so it wont stay sided (as it was in your implementation)
        TargetRotation = new Vector3(0f, _direction.x * _settings.WiggleBoundaries, 0f);
    }

    public bool Fire()
    {
        return Input.GetMouseButtonDown(0);
    }
    public Vector3 Direction { get; private set; }
    public Vector3 TargetRotation { get; private set; }

}
