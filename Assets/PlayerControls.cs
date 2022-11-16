using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] float movementSpeed;

    TimeManager timeManager;

    // Start is called before the first frame update
    void Start()
    {
        timeManager = GameObject.Find("TimeManager").GetComponent<TimeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0f || Input.GetAxisRaw("Vertical") != 0f) timeManager.SpeedUpTime();
        else if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) != 1f || Mathf.Abs(Input.GetAxisRaw("Vertical")) != 1f) timeManager.SlowDownTime();
        transform.position += (Vector3.forward * Input.GetAxisRaw("Vertical") + Vector3.right * Input.GetAxisRaw("Horizontal")) * movementSpeed;
    }
}
