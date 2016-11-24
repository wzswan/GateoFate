using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SenceMoveStr : MonoBehaviour
{

    //public GameMaster gameboy;
    private object SenceMager;
    int n;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        n = Random.Range(0, 10);
    }
    public void Sence()
    {

        if (n < 5)
        {
            SceneManager.LoadScene("str1");
        }
        else
            SceneManager.LoadScene("str2");
    }
}
