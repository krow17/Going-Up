using UnityEngine;
using System.Collections;

public class Teleporter_A : MonoBehaviour {

    public GameObject Arrive_At;
    public GameObject player;
    public bool haveUsed = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    //cite: User Danubian's Teleporter.cs on GitHub
    void OnTriggerEnter(Collider other)
    {
        if (!haveUsed)
        {
            print("Player has entered teleporter");
            Vector3 displacement = player.transform.position - this.transform.position;

            player.transform.position = Arrive_At.transform.position;
            player.transform.position += displacement;
            haveUsed = true;
        }
    }
}
