using System;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _sprite;
    private Vector3 _tempTransform;
    private Vector2 _screenBounds;
    private float _objectHalfWidth;
    private float _objectHalfHeight;
    private void Start()
    {
        _screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        var bounds = _sprite.bounds;
        _objectHalfHeight = bounds.size.y / 2;
        _objectHalfWidth = bounds.size.x / 2;
    }

    private void LateUpdate()
    {
        var position = transform.position;
        _tempTransform.x = Mathf.Clamp(position.x, _screenBounds.x * -1 + _objectHalfWidth, _screenBounds.x - _objectHalfWidth);
        _tempTransform.y = Mathf.Clamp(position.y, _screenBounds.y * -1 + _objectHalfHeight,  _screenBounds.y - _objectHalfHeight);
        transform.position = _tempTransform;
    }
}
