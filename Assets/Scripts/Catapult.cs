using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField]
    private GameObject projectileToFire;

    [SerializeField]
    private Transform projectileSpawnTranform;

    GameObject balaDisparada;

    public void Fire()
    {
        if (projectileToFire!=null) {
            balaDisparada = Projectile.Instantiate(projectileToFire, projectileSpawnTranform);
        }
    }
}