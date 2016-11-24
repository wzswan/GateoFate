using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SenceMoveStar : MonoBehaviour
{

    //public GameMaster gameboy;
    private object SenceMager;
    int n;

    // Use this for initialization
    void Start()
    {
        n = Random.Range(0, 10);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Sence()
    {

        if (n < 5)
        {
            SceneManager.LoadScene("star1");
        }
        else
            SceneManager.LoadScene("star2");
    }
}
