using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserProjectile : MonoBehaviour
{
    private float scaleMovement = 0.05f;
    private Transform laserTransform;

    // Start is called before the first frame update
    void Start()
    {
        laserTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        laserTransform.position += transform.forward * scaleMovement;
    }
}
