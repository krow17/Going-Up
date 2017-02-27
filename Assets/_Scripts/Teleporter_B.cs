using UnityEngine;
using System.Collections;

public class Teleporter_B : MonoBehaviour
{

    public GameObject Arrive_At;
    public int TriggerCounter = -1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
       
        if (TriggerCounter % 2 == 0)
        {
            Vector3 displacement = other.transform.position - this.transform.position;

            other.transform.position = Arrive_At.transform.position;
            other.transform.position += displacement;
        }
        else
            TriggerCounter++;
    }
}
