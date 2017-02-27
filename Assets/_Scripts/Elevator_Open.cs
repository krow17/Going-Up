using UnityEngine;
using System.Collections;

public class Elevator_Open : MonoBehaviour {

    public GameObject leftDoor;
    public GameObject rightDoor;
    bool inRange = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        print("user in range");
        leftDoor.transform.Translate(Vector3.left * 2);
        rightDoor.transform.Translate(Vector3.right * 2);
        Destroy(this.gameObject);
    }
}
