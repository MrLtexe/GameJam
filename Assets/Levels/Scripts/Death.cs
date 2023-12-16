using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        // You can add any initialization code here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // You can add any update code here if needed
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Reset player position
            Player.transform.position = startPoint.transform.position;

            // Reset player rotation to identity (no rotation)
            Player.transform.rotation = Quaternion.identity;
        }
    }
}

