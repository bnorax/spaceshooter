using Unity.VisualScripting;
using UnityEngine;

public class ShipGuns : MonoBehaviour
{
    [SerializeField] private GameObject[] shipGuns;
    [SerializeField] private GameObject shotPrefab;

    public void Fire()
    {
        foreach (var gun in shipGuns)
        {
            var shot = Instantiate(shotPrefab, gun.transform.position, gun.transform.rotation);
        }
    }
}
