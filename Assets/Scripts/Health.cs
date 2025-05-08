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
        Debug.Log($"{gameObject.name} recibi� {amount} de da�o. Salud restante: {currentHealth}");

        if (currentHealth <= 0)
        {
            Debug.Log($"{gameObject.name} ha sido derrotado.");
            // Aqu� puedes poner animaci�n de muerte, desactivaci�n, etc.
        }
    }
}
