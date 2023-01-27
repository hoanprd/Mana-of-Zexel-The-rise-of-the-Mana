using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bom : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.Bom;

        if (ContainerController.Bom <= 0)
        {
            Destroy(gameObject);
        }
    }
}
