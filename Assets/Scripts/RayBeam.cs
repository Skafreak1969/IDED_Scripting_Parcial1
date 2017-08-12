using UnityEngine;

public class RayBeam : MonoBehaviour
{
    [SerializeField]
    private float damage;

    [SerializeField]
    private float rayDistance = 50F;

    public Vector3 targetLocation;
    private Vector3 targetDirection;

    public float DamagePts
    {
        get
        {
            return damage;
        }
    }

    public void Fire()
    {
        Physics.Raycast(transform.position,targetLocation, 10);
    }

    private void OnDrawGizmos()
    {
        Debug.DrawRay(transform.position, targetDirection);
    }
}