using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Photonria : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.Photonria;

        if (ContainerController.Photonria <= 0)
        {
            Destroy(gameObject);
        }
    }
}
