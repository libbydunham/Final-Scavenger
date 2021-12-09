using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}
