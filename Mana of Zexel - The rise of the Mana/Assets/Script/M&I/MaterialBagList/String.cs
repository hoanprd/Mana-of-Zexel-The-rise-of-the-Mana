using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class String : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.String;

        if (ContainerController.String <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
