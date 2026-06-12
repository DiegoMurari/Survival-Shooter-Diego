using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public int healAmount = 25;

    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth player = other.GetComponent<PlayerHealth>();

        if (player != null)
        {
            player.Heal(healAmount);
            Destroy(gameObject);
        }
    }
}