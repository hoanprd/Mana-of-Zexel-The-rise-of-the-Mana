using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cdOuttro : MonoBehaviour
{
    bool ta = true;
    float ct;
    public float sm;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bye");
        ContainerController.DestroyBag = true;
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
            SceneManager.LoadScene("Cutscenes");
        }
    }
    public void SkipTimer()
    {
        ct = 0f;
    }
}
