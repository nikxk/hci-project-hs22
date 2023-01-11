using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform spawnpoint;
    [SerializeField] private GameObject[] bullets;
    private float timer; 
    //private Movement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        //playerMovement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.Space) && timer > attackCooldown) { Attack();}

       timer += Time.deltaTime;
    }

    private void Attack()
    {
        timer = 0;

        bullets[NextBullet()].transform.position = spawnpoint.position;
        bullets[NextBullet()].GetComponent<Attack>().SpawnBullet();

    }

    private int NextBullet()
    {
        for (int i = 0; i <bullets.Length; i++){
            if (!bullets[i].activeInHierarchy){return i;}
        }
        return 0;
    }
}
