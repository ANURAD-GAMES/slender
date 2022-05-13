using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskActive : MonoBehaviour
{
    void Start()
    {
        // Invoke("load", 10f);
        // Task.SetActive(true);
        Invoke("load", 10f);
    }

    void Update()
    {
        
       
    }
}
