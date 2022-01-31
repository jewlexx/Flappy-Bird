using UnityEngine;

public class Pipe : MonoBehaviour
{
    void OnBecameInvisible()
    {
        Destroy(transform.parent.gameObject);
    }
}
