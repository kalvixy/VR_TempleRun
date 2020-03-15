using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathSpawner : MonoBehaviour
{
    public Transform[] PathSpawnPoints;
    public GameObject Path;
    
    
    void OnTriggerEnter(Collider hit)
    {
        if(hit.gameObject.tag == "Player")
        {
            Instantiate(Path, PathSpawnPoints[0].position, PathSpawnPoints[0].rotation);
        }
    }
}
