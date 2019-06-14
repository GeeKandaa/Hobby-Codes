using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer_Script : MonoBehaviour {


    public GameObject Target;
        Vector3 targ;
    public GameObject Player;
    private Vector3 objectPos;
    private float angle;

	// Use this for initialization
	void Start() {
        this.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        //   direction = new Vector2(Target.position.x - transform.position.x, Target.position.y - transform.position.y);
        //   rotation = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //   this.transform.eulerAngles = new Vector3(0, 0, rotation);
        targ = Target.transform.position;
        targ.z = 0f;

        objectPos = Player.transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;

        angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + 90));
    }
}
