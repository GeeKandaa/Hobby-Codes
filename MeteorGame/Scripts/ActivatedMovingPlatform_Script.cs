using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatedMovingPlatform_Script : MonoBehaviour 
{

    [SerializeField]
    private float XDistance;
    [SerializeField]
    private float YDistance;
    [SerializeField]
    private float RotateSpeed;
    [SerializeField]
    private float LerpTime;
    [SerializeField]
    GameObject WaypointClone;
    [SerializeField]
    Transform ParentOfClone;

    float LerpStartTime;
    GameObject location2;
    GameObject location;
    public ActiveSpace Activator;
    private bool started = false;
    

    // Use this for initialization
    void Start()
    {
        

    }

    private void FixedUpdate()
    {
        if (Activator.active == true)
        {
            if (started == false)
            {
                LerpStartTime = Time.time;
                location = Instantiate(WaypointClone, transform.position, Quaternion.identity, ParentOfClone);
                location2 = Instantiate(WaypointClone, transform.position + new Vector3(XDistance, YDistance), Quaternion.identity, ParentOfClone);
                started = true;
            }
            float DeltaTime = Time.time - LerpStartTime;
            float Lerp_Percent = DeltaTime / LerpTime;
            transform.position = Vector3.Lerp(location.transform.position, location2.transform.position, Lerp_Percent);
            transform.Rotate(0, 0, Time.fixedDeltaTime * RotateSpeed);
            if (Lerp_Percent >= 1.0f)
            {
                GameObject temp = location;
                location = location2;
                location2 = temp;
                LerpStartTime = Time.time;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
