using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCollector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bannana"))
        {
            Destroy(collision.gameObject);
        }
    }
}
