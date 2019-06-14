using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Int_Id : MonoBehaviour
{

    public Load_Scene Loader;
    [SerializeField]
    private int id;
    public bool inZone = false;
    public bool Activate = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Loader.id = id;
        inZone = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inZone = false;
    }
    private void Update()
    {
        Activate = Input.GetButtonDown("Submit");
        if (inZone == true && Activate == true)
        {
            Debug.Log("Valid");
            Loader.Load = true;
        }
    }
}
