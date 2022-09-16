using System;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private Vector2 _screenBounds;
    private float _objectHalfWidth;
    private float _objectHalfHeight;
    private void Start()
    {
        _screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        _objectHalfHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
        _objectHalfWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
    }

    private void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, _screenBounds.x * -1 + _objectHalfWidth, _screenBounds.x - _objectHalfWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, _screenBounds.y * -1 + _objectHalfHeight,  _screenBounds.y - _objectHalfHeight);
        transform.position = viewPos;
    }
}
