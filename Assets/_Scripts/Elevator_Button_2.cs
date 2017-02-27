using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Elevator_Button_2 : MonoBehaviour
{

    bool inRange = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q) && inRange)
        {
            SceneManager.LoadScene("_Scenes/Level_3");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        print("in range of button. Press Q");
        inRange = true;
    }
}
