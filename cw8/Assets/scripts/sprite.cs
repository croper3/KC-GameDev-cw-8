using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite : MonoBehaviour
{
    float playerinput;
    public int speed;
    public Rigidbody2D RB;
    public float jump;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        playerinput = Input.GetAxis("Horizontal");
        RB.velocity = new Vector2(playerinput * speed, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RB.velocity = new Vector2(0, jump);
        }

    }
    
}
