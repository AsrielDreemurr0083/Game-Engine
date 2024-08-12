using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Move))]
public class StoneUnit : MonoBehaviour
{

    [SerializeField] private Move move;


    private void Awake()
    {
        move = GetComponent<Move>();
    }

    void Update()
    {
        //float moveZ = 0f;
        //float moveX = 0f;
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    transform.position += new Vector3(0.0f, 0.0f, 1.0f);
        //}else if(Input.GetKeyDown(KeyCode.S))
        //{
        //    transform.position -= new Vector3(0.0f, 0.0f, 1.0f);
        //}else if( Input.GetKeyDown(KeyCode.D))
        //{
        //    transform.position += new Vector3(1.0f, 0.0f, 0.0f);
        //}else if (Input.GetKeyDown(KeyCode.A))
        //{
        //    transform.position -= new Vector3(1.0f, 0.0f, 0.0f);
        //}

        //move.OnMove(Vector3.forward);

        if (Input.GetKeyDown(KeyCode.W))
        {
            move.OnMove(Vector3.forward);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            move.OnMove(Vector3.back);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            move.OnMove(Vector3.right);
        }
        if(Input.GetKeyDown(KeyCode.A)) 
        {
            move.OnMove(Vector3.left);
        }
    }
}
