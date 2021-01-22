using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody2D b;
    // Start is called before the first frame update
    void Start()
    {
        b = GetComponent<Rigidbody2D>();

        b.velocity = new Vector2(6f, 6f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x>=10)
        {
            this.transform.position = new Vector3(0f, 0f,0f);
        }
        if (this.transform.position.x <= -10)
        {
            this.transform.position = new Vector3(0f, 0f,0f);
        }
    }
}
