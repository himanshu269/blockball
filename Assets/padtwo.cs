using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padtwo : MonoBehaviour
{
    Rigidbody2D p2;

    // Start is called before the first frame update
    void Start()
    {
        p2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            p2.velocity = new Vector2(0f, 5f);
        }
        else
            if (Input.GetKey(KeyCode.DownArrow))
        {
            p2.velocity = new Vector2(0f, -5f);
        }
        else
        {
            p2.velocity = new Vector2(0f, 0f);
        }
    }
}
