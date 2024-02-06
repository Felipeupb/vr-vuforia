using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class videoactive : MonoBehaviour
{
    public GameObject video;

    // when i click on the object make the other object active
    private void OnMouseDown() {
        video.SetActive(true);

        gameObject.SetActive(false);
    }
    
}
