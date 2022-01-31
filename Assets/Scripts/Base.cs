using UnityEngine;

public class Base : MonoBehaviour
{
    void OnBecameInvisible()
    {
        Vector3 updatedPos = new Vector3(10, -4,0);
        gameObject.transform.position = updatedPos;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.left * 4 * Time.deltaTime);
    }
}
