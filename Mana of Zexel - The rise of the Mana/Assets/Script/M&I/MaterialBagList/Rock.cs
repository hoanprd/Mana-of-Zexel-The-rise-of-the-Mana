using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rock : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.Rock;

        if (ContainerController.Rock <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
