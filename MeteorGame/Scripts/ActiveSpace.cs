using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSpace : MonoBehaviour {

    public GameObject Display;
    public bool active = false;
    private bool Submitted = false;
    private bool Submittable = false;



    // Use this for initialization
    void Start () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Display.SetActive (true);
        Submittable = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Display.SetActive(false);
        Submittable = false;
    }

    private void Update()
    {
        Submitted = Input.GetButtonDown("Submit");
        if (Submitted == true && Submittable == true)
        {
            active = true;
        }
    }
}
