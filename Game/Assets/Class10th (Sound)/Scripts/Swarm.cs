using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swarm : MonoBehaviour
{
    [SerializeField] AudioClip attackSound;
    [SerializeField] Animator animator;
    [SerializeField] int deathCount;
    public void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        
    }

    void Update()
    {

    }
    public void Walk()
    {

    }

    public void Die()
    {
        animator.SetTrigger("Die");
    }
    public void OnDamage(int count)
    {
        deathCount += count;

        if(deathCount >= 5)
        {
            Die();
        }
        SoundManager.Instance.Sound(attackSound);
    }

    public void Release()
    {
        Destroy(gameObject);
    }
}
