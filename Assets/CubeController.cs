using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour
{

    private float speed = -12;
    private float deadLine = -10;

    void Start()
    {
    }

    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Player")
        GetComponent<AudioSource>().Play();
    }
}