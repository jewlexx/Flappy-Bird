using UnityEngine;

public class Player : MonoBehaviour
{
    public float strength;
    private Rigidbody2D _rb;
    private float _lastUpVel;
    
    // Start is called before the first frame update
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        var vel = _rb.velocity;

        if (!Input.GetButtonDown("Jump"))
        {
            if (_lastUpVel > 0 && vel.y < 0)
            {
                _rb.velocity = Vector2.down * 2;
            }
        }
        else
        {
            _rb.velocity = Vector2.up * 2;
            _rb.AddForce(Vector2.up * strength);
        }

        _lastUpVel = vel.y;
    }
}