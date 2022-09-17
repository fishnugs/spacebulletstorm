using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield: MonoBehaviour
{
    private GameObject player;
    private string shieldDirection;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        shieldDirection = "right";
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w")) {
            shieldDirection = "up";
        } 
        if (Input.GetKey("s")) {
            shieldDirection = "down";
        } 
        if (Input.GetKey("d")) {
            shieldDirection = "right";
        } 
        if (Input.GetKey("a")) {
            shieldDirection = "left";
        }

        // Debug.Log(shieldDirection);

        if (shieldDirection == "up") {
            gameObject.transform.position = player.transform.position + new Vector3(0, 0, 1);
            gameObject.transform.rotation = Quaternion.Euler(0, 360, 0);
        } else if (shieldDirection == "down") {
            gameObject.transform.position = player.transform.position + new Vector3(0, 0, -1);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
        } else if (shieldDirection == "left") {
            gameObject.transform.position = player.transform.position + new Vector3(-1, 0, 0);
            gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
        } else if (shieldDirection == "right") {
            gameObject.transform.position = player.transform.position + new Vector3(1, 0, 0);
            gameObject.transform.rotation = Quaternion.Euler(0, 270, 0);
        }

        
    }
}
