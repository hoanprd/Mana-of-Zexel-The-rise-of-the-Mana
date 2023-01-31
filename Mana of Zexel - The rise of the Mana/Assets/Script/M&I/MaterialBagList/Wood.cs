using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wood : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.Wood;

        if (ContainerController.Wood <= 0)
        {
            Destroy(gameObject);
        }
    }
}
