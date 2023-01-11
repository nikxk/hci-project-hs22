using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handle : MonoBehaviour
{
    [SerializeField] private GameObject[] asteroids;
    [SerializeField] private float timer;
    [SerializeField] private GameObject endScreen;
    private float randomPosition;
    private float time = 0;
    public bool gameOver = false; 
    public int score;
    [SerializeField] public float countdownTimer = 180;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameOver){
            countdownTimer -= Time.deltaTime;
            if(countdownTimer <= 0){
                countdownTimer = 0;
                Lose();
            }
             if(time >= timer){
                Spawn();
            }
            time += Time.deltaTime;
        }
    }
    private void Spawn()
    {
        time = 0;
        randomPosition = Random.Range(-8f, 8f);

        asteroids[NextAsteroid()].transform.position = new Vector3(randomPosition, 5.5f, 0);
        asteroids[NextAsteroid()].GetComponent<AsteroidScript>().SpawnAsteroid();

    }

    private int NextAsteroid()
    {
        for (int i = 0; i <asteroids.Length; i++){
            if (!asteroids[i].activeInHierarchy){return i;}
        }
        return 0;
    }
    public void Lose()
    {
        gameOver = true;
        endScreen.SetActive(true);
    }
}
