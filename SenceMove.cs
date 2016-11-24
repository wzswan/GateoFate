using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SenceMove : MonoBehaviour {

    //public GameMaster gameboy;
    private object SenceMager;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Sence()
    {
        
        SceneManager.LoadScene("Sence00");
    }
}
