using Unity.VisualScripting;
using UnityEngine;

public class PCControls : IShipInput
{
    public void ReadInput()
    {
        Position = new Vector3(
            Input.GetAxis("Horizontal"), 
            Input.GetAxis("Vertical"), 0);
    }

    public bool Fire()
    {
        return Input.GetMouseButtonDown(0);
    }
    public Vector3 Position { get; private set; }
}
