using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieStats : MonoBehaviour
{
    protected int health;
    public int damage {  get; private set; }
    public float attackSpeed;
    protected bool isDead;
    private bool canAttack;
    [field:SerializeField] public PlayerController playerController { get; private set; }

    void Start()
    {
        health = 50;
        isDead = false;
        damage = 10;
        attackSpeed = 1.5f;
        canAttack = true;
    }
    public void CheckHealth()
    {
        if (health <= 0)
        {
            health = 0;
            Dead();
        }
    }
    public void Dead()
    {
        isDead = true;
        Destroy(gameObject);
    }
    public void TakeDamage(int incomingDamage)
    {
        health -= incomingDamage;
        CheckHealth();
        Debug.Log("damage dealt");
    }
    public int DealDamage(int statsToDamage)
    {
        statsToDamage -= damage;
        return statsToDamage;
    }
    void Update()
    {

    }
}
