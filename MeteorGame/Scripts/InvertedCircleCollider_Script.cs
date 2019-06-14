using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertedCircleCollider_Script : MonoBehaviour {

    int NumEdges = 10000;
    float Radius;
    //double bound_size;

	// Use this for initialization
	void Start () {

        //bound_size = GetComponent<CircleCollider2D>().radius;
        //Radius = (float)bound_size;
        Radius = 10.77f;
        EdgeCollider2D edgeCollider = GetComponent<EdgeCollider2D>();
        Vector2[] points = new Vector2[NumEdges];

        for (int i =0; i < NumEdges; i++){
         
            float angle = 2* Mathf.PI * i / NumEdges;
            float x = Radius * Mathf.Cos(angle);
            float y = Radius * Mathf.Sin(angle);

            points[i] = new Vector2(x, y);
        }
        edgeCollider.points = points;
	}
}
