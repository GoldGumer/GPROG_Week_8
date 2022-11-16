using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField] float timeSlowMultiplier;

    bool isTimeSlowed = false;

    public void SlowDownTime()
    {
        if (!isTimeSlowed)
        {
            Time.timeScale = timeSlowMultiplier;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
            isTimeSlowed = true;
        }
    }

    public void SpeedUpTime()
    {
        if (isTimeSlowed)
        {
            Time.timeScale = 1f;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
            isTimeSlowed = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(isTimeSlowed);
    }
}
