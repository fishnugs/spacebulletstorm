using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMovement : MonoBehaviour
{
    private float scaleMovement = 0.05f;
    public Transform spawnerTransform;
    private float spawnFrequency = 2.0f;
    public LaserSpawner laserSpawnerScript;

    // Start is called before the first frame update
    void Start()
    {
        laserSpawnerScript = GetComponent<LaserSpawner>();
        spawnerTransform = GetComponent<Transform>();
        StartCoroutine(Delay());

    }

    public IEnumerator Delay()
    {
        while (true) {
            yield return new WaitForSeconds(spawnFrequency);
            laserSpawnerScript.SpawnLaser();
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        // if (collisionInfo.tag == "projectile") {
        //     // TODO: Player gets points
        // }
    }

    bool IsInBound()
    {
        return (laserSpawnerScript.tag == "SpawnerHorizontal" && -15 < spawnerTransform.position.x && spawnerTransform.position.x < 15) || ((laserSpawnerScript.tag == "SpawnerLeft" || laserSpawnerScript.tag == "SpawnerRight") && -10 < spawnerTransform.position.z && spawnerTransform.position.z < 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (IsInBound()) {
            spawnerTransform.position += transform.up * scaleMovement;
        } else {
            scaleMovement = scaleMovement * -1;
            spawnerTransform.position += transform.up * scaleMovement;
        }


    }
}
