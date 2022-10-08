using System.ComponentModel;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnEnemyShips : MonoBehaviour
{
    [SerializeField] private GameObject _spawnField;
    [SerializeField] private ShipSettings _shipSettings;
    [SerializeField] private GameObject _ship;
    [SerializeField] private Vector2 topRightBound;
    [SerializeField] private Vector2 bottomLeftBound;
    [SerializeField]private int _numberKeepAlive = 0;
    private int _numberInScene = 0;
    
    private void Start()
    {
    }

    private void Update()
    {
        if (!_shipSettings.Spawn) return;
        _numberInScene = transform.childCount;
        if (_numberInScene < _numberKeepAlive)
        {
            float posX = Random.Range(topRightBound.x, bottomLeftBound.x);
            float posY = Random.Range(topRightBound.y, bottomLeftBound.y);
            GameObject go = Instantiate(_ship, transform);
            go.transform.Translate(new Vector3(posX, posY));
            _numberInScene++;
        }
    }
}
