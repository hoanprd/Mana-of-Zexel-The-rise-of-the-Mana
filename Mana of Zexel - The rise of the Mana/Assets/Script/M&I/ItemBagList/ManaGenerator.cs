using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaGenerator : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ManaGenerator;

        if (ContainerController.ManaGenerator <= 0)
        {
            Destroy(gameObject);
        }
    }
}
