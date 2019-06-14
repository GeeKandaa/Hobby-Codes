using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoller_Custom : MonoBehaviour {

    [SerializeField]
    private GameObject trackingTarget;
    [SerializeField]
    private float CameraSpeed = 9999999;
    public GameObject TrackingTarget
    {
        get
        {
            return trackingTarget;
        }
        set
        {
            trackingTarget = value;
        }
    }

    bool flipped = false;
    private Camera GetCamera;


	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
    

    void Update () {
        if (trackingTarget.GetComponent<SpriteRenderer>().flipX == true && flipped == false)
        {
            flipped = true;
        }
        else if (trackingTarget.GetComponent<SpriteRenderer>().flipX == false && flipped == true) 
        {
            flipped = false;
        }

        float XTarget = trackingTarget.transform.position.x;
        float YTarget = trackingTarget.transform.position.y + 10;

        float XNew = Mathf.Lerp(transform.position.x, XTarget, CameraSpeed);
        float YNew = Mathf.Lerp(transform.position.y, YTarget, CameraSpeed);
        transform.position = new Vector3(XNew, YNew, transform.position.z);
    }
}
