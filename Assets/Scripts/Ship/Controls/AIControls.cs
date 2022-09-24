using UnityEngine;

public class AIControls : IShipInput
{
    public AIControls(Transform transform, ShipSettings settings)
    {
        _transform = transform;
        _settings = settings;
    }
    
    private ShipSettings _settings;
    private Transform _transform;
    private float _timeElapsed = 0f;
    private float _timeShot, _timeMoved;
    private float _deltaX;
    public void ReadInput()
    {
        _timeElapsed += Time.deltaTime;
        
        float target = Mathf.Lerp(-_settings.Boundary, _settings.Boundary, Mathf.PingPong(Time.time, 1.0f));
        // _transform.position = position;

        var deltaX = target * Time.deltaTime * _settings.MoveSpeed*100f;
        Direction = new Vector3(
            target-_transform.position.x, 0, 0);
    }

    public bool Fire()
    {
        if (_timeElapsed - _timeShot > 1.0f)
        {
            _timeShot = _timeElapsed;
            return true;
        }
        return false;
    }
    public Vector3 Direction { get; private set; }
    public Vector3 TargetRotation { get; private set; }
}