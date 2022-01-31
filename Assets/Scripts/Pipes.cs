using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float x;
    public float y;
    public float delay;

    public void Create()
    {
        var obj = Instantiate(GameObject.FindGameObjectWithTag("Pipe"), transform, false);

        obj.transform.position = new Vector3(x, y + Random.Range(-1.74F, 1.74F), 0);
        obj.name = "Pipe Couple";
    }

    void Start()
    { 
        GameObject.FindGameObjectWithTag("Pipe").transform.position = new Vector3(x, y, 0);
        
        InvokeRepeating(nameof(Create), delay, delay);
    }

    void Update()
    {
        // gameObject.transform.Translate(Vector3.down * 4 * Time.deltaTime);
    }
}
