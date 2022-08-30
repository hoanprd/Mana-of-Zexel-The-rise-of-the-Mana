using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cd : MonoBehaviour
{
    bool ta = true;
    float ct;
    public float sm;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi");
        ct = sm * 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (ta == true)
        {
            ct -= Time.deltaTime;
        }
        if (ct < 0)
        {
            SceneManager.LoadScene(1);
        }
    }
    public void SkipTimer()
    {
        ct = 0f;
    }
}
