using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControler : MonoBehaviour
{
    public Transform start, end;
    public int speed;
    Vector2 targetPos;


    // Start is called before the first frame update
    void Start()
    {
        targetPos = end.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, start.position) < .1f) targetPos = end.position;

        if (Vector2.Distance(transform.position, end.position) < .1f) targetPos = start.position;

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
