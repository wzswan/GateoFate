using UnityEngine;
using System.Collections;

public class Reciprocating : MonoBehaviour {

    public float minx = 2f;
    public float maxx = 3f;

	// Use this for initialization
	void Start () {

        minx = transform.position.x;
        maxx = transform.position.x + 5;
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(Mathf.PingPong(Time.time * 1, maxx - minx) + minx, transform.position.y, transform.position.z);
	
	}
}
