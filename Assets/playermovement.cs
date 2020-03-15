using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody player;
    public float playerSpeed =-2.0f;
    public bool left;
    public bool middle;
    public bool right;
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        player.velocity = new Vector3(0, 0, playerSpeed);
    
        if (Input.GetKey(KeyCode.Space))
        {
           // Vector3 up = transform.TransformDirection(Vector3.up);
           // player.AddForce(up * 100, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && this.transform.position.x < 3.432)
        {


           this.transform.Translate(-3,0,0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)&& this.transform.position.x > -2.54)
        {


            this.transform.Translate(3,0,0);
        }

    }
    
}
