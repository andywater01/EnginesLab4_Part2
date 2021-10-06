using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ClickScore : MonoBehaviour {
    public static event Action clicked;
    public AudioSource audio;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Working");
            #region observer        
            clicked?.Invoke();
            #endregion
        }

    }
}
    
