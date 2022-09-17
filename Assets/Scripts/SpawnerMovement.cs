using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMovement : MonoBehaviour
{
    private float scaleMovement = 0.05f;
    private Transform spawnerTransform;
    private float spawnFrequency = 2.0f;
    private LaserSpawner laserSpawner;

    // Start is called before the first frame update
    void Start()
    {
        spawnerTransform = GetComponent<Transform>();
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(spawnFrequency);
        laserSpawner.SpawnLaser();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        // if (collisionInfo.tag == "projectile") {
        //     // TODO: Player gets points
        // }
    }

    Vector3 GetSpawnerPosition()
    {
        return spawnerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (-15 < spawnerTransform.position.x && spawnerTransform.position.x < 15 && -15 < spawnerTransform.position.z && spawnerTransform.position.z < 15) {
            spawnerTransform.position += transform.up * scaleMovement;
        } else {
            scaleMovement = scaleMovement * -1;
            spawnerTransform.position += transform.up * scaleMovement;
        }


    }
}
