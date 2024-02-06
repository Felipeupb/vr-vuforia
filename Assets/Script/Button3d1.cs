using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Button3d1 : MonoBehaviour
{
  UnityEvent unityEvent;
  public string urls;


     void OnMouseDown() 
     {
        
        Application.OpenURL(urls);
     }
     
    
}


