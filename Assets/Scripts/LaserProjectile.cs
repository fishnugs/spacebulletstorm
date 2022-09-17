using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserProjectile : MonoBehaviour
{
    private float scaleMovement = 0.08f;
    private Transform laserTransform;

    // Start is called before the first frame update
    void Start()
    {
        laserTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (-20 < laserTransform.position.x && laserTransform.position.x < 20 && -20 < laserTransform.position.z && laserTransform.position.z < 20 && -20 < laserTransform.position.y && laserTransform.position.y < 20) {
            laserTransform.position += transform.forward * scaleMovement;
        } else {
            Destroy(gameObject);
        }
    }
}
