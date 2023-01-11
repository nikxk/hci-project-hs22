using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    [SerializeField] private GameObject handler;
    private float time;
    private string timeInMinutes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeToMinutes(handler.GetComponent<Handle>().countdownTimer);

        timeText.text = "Time: " + timeInMinutes;
        
    }
    private void TimeToMinutes(float time){
        if (time >= 120){
            timeInMinutes = "2:" + (time-120).ToString("0");
        }else if (time >= 60){
            timeInMinutes = "1:" + (time-60).ToString("0");
        }else{
            timeInMinutes = time.ToString("0");
        }
    }
}
