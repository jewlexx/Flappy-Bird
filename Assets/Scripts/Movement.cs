using UnityEngine;

public class Movement : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.Translate(Vector3.left * 4 * Time.deltaTime);
    }
}
