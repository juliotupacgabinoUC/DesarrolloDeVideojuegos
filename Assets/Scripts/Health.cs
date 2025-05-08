using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        Debug.Log($"{gameObject.name} recibió {amount} de daño. Salud restante: {currentHealth}");

        if (currentHealth <= 0)
        {
            Debug.Log($"{gameObject.name} ha sido derrotado.");
            // Aquí puedes poner animación de muerte, desactivación, etc.
        }
    }
}
