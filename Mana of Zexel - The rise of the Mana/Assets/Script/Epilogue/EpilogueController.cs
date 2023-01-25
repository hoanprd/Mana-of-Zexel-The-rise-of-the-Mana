using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EpilogueController : MonoBehaviour
{
    bool ta = true;
    float ct;
    public float sm;

    // Start is called before the first frame update
    void Start()
    {
        ct = sm;
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
            SceneManager.LoadScene("Splash");
        }
    }
}
