using System;
using System.ComponentModel;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField]private ShipSettings shipSettings;
    [SerializeField]private ShipGuns shipGuns;
    private IShipInput _shipInput;
    private ShipMotor _shipMotor;
    
    private void Awake()
    {
        _shipInput = new PCControls(); ;
        _shipMotor = new ShipMotor(_shipInput, transform, shipSettings);
    }

    void Update()
    {
        _shipInput.ReadInput();
        if (_shipInput.Fire()) shipGuns.Fire();
        _shipMotor.Tick();
    }
}
