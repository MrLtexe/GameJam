using UnityEngine;

public class Pickup : MonoBehaviour
{
    private PickupManager pickupManager;

    void Start()
    {
        pickupManager = GameObject.FindObjectOfType<PickupManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Assuming the player collected the pickup
            Destroy(gameObject);
            pickupManager.PickupCollected();
        }
    }
}
