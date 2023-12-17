using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControler : MonoBehaviour
{
    public Transform A, B;
    public int speed;
    Vector2 targetPos;


    // Start is called before the first frame update
    void Start()
    {
        targetPos = B.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, A.position) < .1f) targetPos = B.position;

        if (Vector2.Distance(transform.position, B.position) < .1f) targetPos = A.position;

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(this.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}
