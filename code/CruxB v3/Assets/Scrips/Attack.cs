using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject handler;
    private bool hit;
    private BoxCollider2D box;
    private float lifetime;


    // Start is called before the first frame update
    void Awake()
    {
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!handler.GetComponent<Handle>().gameOver){
        if (hit) {return;}
        transform.Translate(0, speed * Time.deltaTime, 0);

        lifetime += Time.deltaTime;
        if(lifetime > 3){Deactivate();}
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hit = true;
        box.enabled = false;

        Deactivate();
        handler.GetComponent<Handle>().score ++;

    }
    public void SpawnBullet()
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
