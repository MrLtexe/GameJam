using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public float fallSpeed = 10f;
    public GameObject startPoint;
    public GameObject player;

    private void Start()
    {
        transform.position = new Vector3(Random.Range(-2f, 2f), 10f, 0f);
    }

    private void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * fallSpeed);

        if (transform.position.y < -5f)
        {
            transform.position = new Vector3(Random.Range(-2f, 2f), 10f, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object is the player
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player entered trigger!");
            // Move the player to the respawn point
            player.transform.position = startPoint.transform.position;
            Debug.Log("Player respawned at start point!");
        }
    }
}
