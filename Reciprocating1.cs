using UnityEngine;
using System.Collections;

public class Reciprocating1 : MonoBehaviour
{

    public float minz = 2f;
    public float maxz = 3f;

    // Use this for initialization
    void Start()
    {

        minz = transform.position.z;
        maxz = transform.position.z +50;

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time * 1, maxz - minz) + minz);

    }
}
