
using UnityEngine;

public class PlayerCollisionFire : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("We Hit Something");
    }
}
