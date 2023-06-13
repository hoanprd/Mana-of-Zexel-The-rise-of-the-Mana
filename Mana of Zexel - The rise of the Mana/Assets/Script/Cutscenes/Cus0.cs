using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus0 : MonoBehaviour
{
    public GameObject Dia0;

    bool ta = true;
    public float ct;
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
            ta = false;
            CutscenesController.cus0 = 1;
            SceneManager.LoadScene("Cutscenes");
        }
    }
}
