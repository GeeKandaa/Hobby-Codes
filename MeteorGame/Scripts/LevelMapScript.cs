using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMapScript : MonoBehaviour {

    [SerializeField]
    PlayerControllerRoll Player;
    Transform[] map_elems;
    float x;
    public float Rotation_Speed;
    //private bool isLocked = true;
    //public bool IsLocked
    //{
    //    get
    //    {
    //        return isLocked;
    //    }
    //    set
    //    {
    //        isLocked = value;
    //    }
    //}

    // Use this for initialization
    void Start () {

        map_elems = GetComponentsInChildren<Transform>();
        
      
	}
	
	// Update is called once per frame
	void Update () {
        //if (isLocked == false)
        //{
            if (Player.Grounded_Alt == true)
            {
                x = Input.GetAxis("Horizontal") * Rotation_Speed;
                transform.Rotate(Vector3.forward * Time.deltaTime * -x);
                for (int i = 0; i < map_elems.Length; i++)
                {
                    // map_elems[i].transform.Rotate(Vector3.forward * Time.deltaTime * -x, Space.World);
                    //  map_elems[i].transform.Rotate(Vector3.forward * Time.deltaTime * x/2, Space.Self);
                }
            }
        ///}
	}
}
