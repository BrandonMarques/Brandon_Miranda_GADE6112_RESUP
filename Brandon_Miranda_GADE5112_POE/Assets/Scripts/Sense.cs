using System;
using UnityEngine;

public class Sense : MonoBehaviour
{
    public float checkRadius;
    public LayerMask checkLayers;

    // Update is called once per frame
    private void Update()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, checkRadius, checkLayers);
        Array.Sort(colliders, new DistanceComparer(transform));

        foreach(Collider item in colliders)
        {
            if(item.gameObject.tag != this.tag)
            {
                transform.LookAt(item.transform);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, checkRadius);
    }
}
