using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Porridge : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.Porridge;

        if (ContainerController.Porridge <= 0)
        {
            Destroy(gameObject);
        }
    }
}
