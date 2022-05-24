using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "DeathWall" || col.gameObject.name == "DeathWall (1)" || col.gameObject.name == "DeathWall (2)" || col.gameObject.name == "DeathWall (3)") {
            transform.position = new Vector3(0, 0.5f, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }

    void OnCollisionExit(Collision col)
    {
           transform.position = new Vector3(0, 0.5f, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
    }
}
