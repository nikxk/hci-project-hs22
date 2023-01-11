using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody2D playerBody;
    [SerializeField] private float speed;
    [SerializeField] private GameObject handler;
    // Start is called before the first frame update
    void Start()
    {
       playerBody = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(!handler.GetComponent<Handle>().gameOver){
            if((Input.GetKey("left") && transform.position.x >= -8.7) || (Input.GetKey("right") && transform.position.x <= 8.7))
            {
                transform.position = transform.position + new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime * speed,0,0);
            }   
            if((Input.GetAxis("Horizontal")) == 0){playerBody.velocity = new Vector2(0, playerBody.velocity.y);}
        }
    }
}
