using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SOManager.Instance.score++;
            Destroy(this.gameObject);
            Debug.Log("Item collected!");
        }
    }
}