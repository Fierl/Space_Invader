using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotController : MonoBehaviour
{
    public float horizontalSpeed = 3.0f; 

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.y = position.y - horizontalSpeed * Time.deltaTime;
        transform.position = position;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController >();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
            Destroy(gameObject);
        }
    }

}
