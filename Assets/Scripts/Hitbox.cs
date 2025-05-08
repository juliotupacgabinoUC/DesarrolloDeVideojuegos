using UnityEngine;

public class Hitbox : MonoBehaviour
{
    public int damage = 10;
    public string targetTag; // O "Player" para el enemigo

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(targetTag))
        {
            Health targetHealth = other.GetComponent<Health>();
            if (targetHealth != null)
            {
                targetHealth.TakeDamage(damage);
            }
        }
    }
}
