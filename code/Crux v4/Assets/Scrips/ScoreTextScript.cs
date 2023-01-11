using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreTextScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    [SerializeField] private GameObject handler;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + handler.GetComponent<Handle>().score.ToString();
    }

}
