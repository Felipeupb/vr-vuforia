using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrlOpen : MonoBehaviour
{
    public string url;

    public void OpenUrl()
    {
        Application.OpenURL(url);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
