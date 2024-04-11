using UnityEngine;

public class Laser : MonoBehaviour
{
    public float endTranslationPositionY;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.up);

        if (transform.position.y > endTranslationPositionY)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D()
    {
        Destroy(gameObject);
    }
}
