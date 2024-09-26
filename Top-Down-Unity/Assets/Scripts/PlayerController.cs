using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private SpriteRenderer sr;

    //sprite variables
    public Sprite upSprite;
    public Sprite leftSprite;
    public Sprite rightSprite;
    public Sprite frontSprite;

    //public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;

        //go right
        if (Input.GetKey("d"))
        {
            newPosition.x += speed;
            //change sprite to right sprite
            sr.sprite = rightSprite;
        }

        //go left
        if (Input.GetKey("a"))
        {
            newPosition.x -= speed;
            //change sprite to left sprite
            sr.sprite = leftSprite;
        }

        //go up
        if (Input.GetKey("w"))
        {
            newPosition.y += speed;
            //change sprite to up sprite
            sr.sprite = upSprite;
        }

        //go down
        if (Input.GetKey("s"))
        {
            newPosition.y -= speed;
            //change sprite to front sprite
            sr.sprite = frontSprite;
        }

        transform.position = newPosition;
    }
}

