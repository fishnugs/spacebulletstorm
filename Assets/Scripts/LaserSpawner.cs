using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawner : MonoBehaviour
{
    public GameObject laser;
    public SpawnerMovement spawnerMovementScript;

    // Start is called before the first frame update
    void Start()
    {
        spawnerMovementScript = GetComponent<SpawnerMovement>();
    }

    public void SpawnLaser()
    {
        Vector3 rotDeg;
        if (spawnerMovementScript.tag == "SpawnerLeft") {
            rotDeg = new Vector3(0, 90, 0);
        } else if (spawnerMovementScript.tag == "SpawnerRight") {
            rotDeg = new Vector3(0, -90, 0);
        } else {
            rotDeg = new Vector3(180, 0, 0);
        }

        laser = GameObject.Instantiate(Resources.Load("Projectile"), spawnerMovementScript.spawnerTransform.position, Quaternion.Euler(rotDeg)) as GameObject;
    }
}
