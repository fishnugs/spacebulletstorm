using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield: MonoBehaviour
{
    private GameObject player;
    // private 

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = player.transform.position + new Vector3(0, 0, 1);
    }
}
