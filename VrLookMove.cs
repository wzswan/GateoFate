using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class VrLookMove : MonoBehaviour {

    public Transform vrCamera;
    public float toggleAngle = 30.0f;
    public float speed = 3.0f;
    public bool moveForward;
    private CharacterController cc;
    private Vector3 startPos;
    //End
    private Vector3 endPos;
    //Distance
    private float distance = 260f;

    //public bool moveForward;

    // public float toggleAngle = 30.0f;

    //public Transform vrCamera;

    //Time to take from start to end
    private float lerpTime = 50;
    //This will update the lerp time
    private float currentLerpTime = 0;

    // Use this for initialization
    void Start () {

        cc = GetComponent<CharacterController>();
        startPos = vrCamera.transform.position;
        endPos = vrCamera.transform.position + Vector3.down * distance;
    }
	
	// Update is called once per frame
	void Update () {

        if(vrCamera.eulerAngles.x>= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }
        if (moveForward)
        {
          //  Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
         //   cc.SimpleMove(forward * speed);
            currentLerpTime += Time.deltaTime;
            if (currentLerpTime >= lerpTime)
            {
                currentLerpTime = lerpTime;
            }
            float Perc = currentLerpTime / lerpTime;
            vrCamera.transform.position = Vector3.Lerp(startPos, endPos, Perc);

            if (currentLerpTime == lerpTime)
            {
                SceneManager.LoadScene("badEnd");
            }
        }
	
	}
}
