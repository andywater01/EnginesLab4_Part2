using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class SceneManagerScript : MonoBehaviour
{
    public Text ValueText;
    public Text HealthText;
    
    public static event Action clicked;
    
    // Start is called before the first frame update
    void Start()
    {
        ValueText.text = PersistentManagerScript.Instance.Value.ToString();
        HealthText.text = HealthManagerScript.Instance.health.ToString();
    }

    

    public void GoToFirstScene()
    {

        PersistentManagerScript.Instance.Value += 1;
        ValueText.text = PersistentManagerScript.Instance.Value.ToString();

        HealthManagerScript.Instance.health -= 1;
        HealthText.text = "Health = " + HealthManagerScript.Instance.health.ToString();

        

        SceneManager.LoadScene("Scene1");

    }

    public void GoToSecondScene()
    {

        PersistentManagerScript.Instance.Value += 1;
        ValueText.text = PersistentManagerScript.Instance.Value.ToString();

        HealthManagerScript.Instance.health -= 1;
        HealthText.text = "Health = " + HealthManagerScript.Instance.health.ToString();

        

        SceneManager.LoadScene("Scene2");
    }

    
}


    
