using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionManager : MonoBehaviour
{
    [SerializeField] GameObject cloud;
    [SerializeField] Transform[] spawners;  
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ResetPosition", 5, 5);
    }

    public void ResetPosition()
    {
        int random = Random.Range(0, spawners.Length);

        cloud.transform.position = spawners[random].position;
        Debug.Log(spawners[random].position);
    }
}
