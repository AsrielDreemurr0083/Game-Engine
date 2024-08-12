using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(1, 1, 1);
    }

    // Update is called once per frame

    public void OnMove(Vector3 direction)
    {
        transform.position += direction;
    }
}
