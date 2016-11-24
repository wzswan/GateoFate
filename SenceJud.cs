using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SenceJud : MonoBehaviour {

    int n;
    private object SenceMager;

    // Use this for initialization
    void Start () {
        n = Random.Range(0, 10);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Sence()
    {

        if (n < 5)
        {
            SceneManager.LoadScene("judgement1");
        }
        else
            SceneManager.LoadScene("judgement2");
    }
}
