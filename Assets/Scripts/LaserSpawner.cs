using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawner : MonoBehaviour
{
    private LaserProjectile laser;
    private SpawnerMovement spawnerMovementScript;


    // Start is called before the first frame update
    void Start()
    {
        spawnerMovementScript = GameObject.FindObjectOfType<SpawnerMovement>;
    }

    void SpawnLaser()
    {
        laser = GameObject.Instantiate(Resources.Load("Models/Projectile"), spawnerMovementScript.GetSpawnerPosition(), Quaternion.identity);
    }
}
