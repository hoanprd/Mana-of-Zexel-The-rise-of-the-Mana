using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UltraBom : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.UltraBom;

        if (ContainerController.UltraBom <= 0)
        {
            Destroy(gameObject);
        }
    }
}
