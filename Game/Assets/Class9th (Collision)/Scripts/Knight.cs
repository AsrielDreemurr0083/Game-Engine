using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    WALK,
    ATTACK,
    DIE
}

public class Knight : MonoBehaviour
{
    [SerializeField] State state;
    [SerializeField] Animator animator;
    [SerializeField] float speed = 2.5f;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        switch (state)
        {
            case State.WALK: Walk(); 
                break;
            case State.ATTACK: Attack();
                break;
            case State.DIE: Die(); 
                break;
        }       

    }

    public void Walk()
    {
        animator.SetBool("Attack", false);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void Attack()
    {
        animator.SetBool("Attack", true);

    }
    public void Die()
    {
        animator.Play("Die");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            state = State.ATTACK;
        }

    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            state = State.DIE;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // OnCollisionEnter : 물리적인 충돌이 일어났을 때 호출되는 이벤트 함수
        Debug.Log("OnCollisionEnter");
    }

    private void OnCollisionStay(Collision collision)
    {
        // OnCollisionStay : 물리적인 충돌을 하고 있는 중일 때 호출되는 이벤트 함수
        Debug.Log("OnCollisionStay");
    }

    private void OnCollisionExit(Collision collision)
    {
        // OncollisionExit : 물리적인 충돌이 끝났을 때 호출되는 이벤트 함수
        Debug.Log("OnCollisionExit");
    }
}
