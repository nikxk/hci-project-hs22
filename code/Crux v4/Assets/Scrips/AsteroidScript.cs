using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    private bool hit;
    private BoxCollider2D box;
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private GameObject handler;
    private Rigidbody2D asteriodBody;
    private float lifetime;

    // Start is called before the first frame update
    void Awake()
    {
        box = GetComponent<BoxCollider2D>();
        asteriodBody = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(!handler.GetComponent<Handle>().gameOver){
        if (hit) {return;}
        //transform.Translate(0, -speed * Time.deltaTime, 0);
        transform.position = transform.position + new Vector3(0,-Time.deltaTime * speed,0);
        transform.Rotate(0,0, rotationSpeed *Time.deltaTime, Space.Self);

        lifetime += Time.deltaTime;
        if(lifetime > 8){Deactivate();}
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player") { handler.GetComponent<Handle>().Lose();}
        if(collision.gameObject.name == "BottemBoundery") { handler.GetComponent<Handle>().Lose();}
        hit = true;
        box.enabled = false;
        Deactivate();

    }
    public void SpawnAsteroid()
    {
        gameObject.SetActive(true);
        hit = false;
        lifetime = 0;
        box.enabled = true;
    }
    private void Deactivate()
    {
        gameObject.SetActive(false);

    }
}
