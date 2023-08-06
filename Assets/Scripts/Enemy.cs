using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float startSpeed = 10f;
    
    [HideInInspector]
    public float speed;

    public float startHealth = 100;
    private float health;

    public int Worth = 50;

    public GameObject DeathEffect;

    [Header("Unity Stuff")]
    public Image healthBar;

    void Start()
    {
        speed = startSpeed;
        health = startHealth;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        healthBar.fillAmount = health / startHealth;
        if (health <= 0)
        {
            Die();
        }

    }

    public void Slow (float pct)
    {
        speed = startSpeed * (1f - pct);
    }

    void Die()
    {
        PlayerStats.Money += Worth;

        GameObject effect = (GameObject)Instantiate(DeathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 2f);

        Destroy(gameObject);
    }
}
