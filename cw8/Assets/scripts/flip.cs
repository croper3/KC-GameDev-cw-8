using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{
    SpriteRenderer sprite;
    bool faceright = true;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        FlipPlayer();
    }

    void FlipPlayer()
    {
        if (Input.GetKeyDown(KeyCode.D) && faceright == false)
        {
            sprite.flipX = false;
                faceright = true;
        }
        else if (Input.GetKeyDown(KeyCode.A) && faceright == true)
        {
            sprite.flipX = true;
            faceright = false;
        }
        
    }

    
}
