using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaCloth : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ManaCloth;

        if (ContainerController.ManaCloth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
