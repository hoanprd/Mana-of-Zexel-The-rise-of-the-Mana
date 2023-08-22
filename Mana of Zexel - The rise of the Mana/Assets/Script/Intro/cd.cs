using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cd : MonoBehaviour
{
    public AudioSource OPBGM;
    public GameObject FadeIn;

    bool ta = true;
    float ct;
    int once;
    public float sm;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi");

        once = 0;

        if (!PlayerPrefs.HasKey("SBGM"))
        {
            OPBGM.volume = 0.5f;
        }
        else
        {
            OPBGM.volume = PlayerPrefs.GetFloat("SBGM");
        }

        //FadeOut.SetActive(true);

        //OPBGM.Play();

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
            //SceneManager.LoadScene("StartMenu");
            StartCoroutine(DelayFadeIn());
        }
    }
    public void SkipTimer()
    {
        if (once == 0)
        {
            once = 1;
            ct = 0f;
        }
    }

    IEnumerator DelayFadeIn()
    {
        FadeIn.SetActive(true);

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("StartMenu");
    }
}
