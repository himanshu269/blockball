using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padone : MonoBehaviour
    {
    Rigidbody2D p;
    
    // Start is called before the first frame update
    void Start()
    {
        p = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            p.velocity = new Vector2(0f, 5f);
        }
        else
            if (Input.GetKey(KeyCode.S))
        {
            p.velocity = new Vector2(0f, -5f);
        }
        else
        {
            p.velocity = new Vector2(0f, 0f);
        }
    }
}
