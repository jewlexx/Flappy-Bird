using UnityEngine;

public class Background : MonoBehaviour
{
    public Sprite nightSprite;

    void Awake()
    {
        var hour = System.DateTime.Now.Hour;

        if (hour < 8 || hour > 20)
        {
            GetComponent<SpriteRenderer>().sprite = nightSprite;
        }
    }
}
