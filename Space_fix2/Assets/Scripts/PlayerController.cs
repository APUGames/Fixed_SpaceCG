using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;
    private void Awake()
    {
        Debug.Log("I am awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        /*screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
        Debug.Log("I am a player"); 
        Debug.Log(speed);
        //transform.position = new Vector3(transform.position.x + 300.0f, transform.position.y, transform.position.z);*/
    }
    /*void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x, screenBounds.x * -1 - objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y, screenBounds.y * -1 - objectHeight);
        transform.position = viewPos;
    }*/
    // Update is called once per frame
    void Update()
    {
       //float speed = 50.0f; 
        float horizontalDirection = Input.GetAxis("Horizontal");
        float verticalDirection = Input.GetAxis("Vertical");
        //Debug.Log(direction);
        transform.Translate(speed * Time.deltaTime * new Vector2(horizontalDirection, verticalDirection));
        //gameObject.transform.Rotate(new Vector3(5.0f,5.0f));
        // transform.position = new Vector3(transform.position.x + 1.0f, transform.position.y, transform.position.z);
    }
}
