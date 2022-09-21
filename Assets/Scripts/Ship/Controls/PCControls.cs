using Unity.VisualScripting;
using UnityEngine;

public class PCControls : IShipInput
{
    private Vector3 _direction;
    private Vector3 _rotation;
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
        _rotation.Set(0f, _direction.x, 0f);
            
        Direction = _direction; //for now? testing
        Rotation = _rotation;
    }

    public bool Fire()
    {
        return Input.GetMouseButtonDown(0);
    }
    public Vector3 Direction { get; private set; }
    public Vector3 Rotation { get; private set; }

}
