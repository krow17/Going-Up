using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Conditional_Teleporter : MonoBehaviour {

    public GameObject Arrive_At;
    public GameObject player;
    public GameObject pill;
    public GameObject pill2;
    public Canvas textCanvas;
    public AudioClip awfulSound;

    public bool inRange = false;
    public bool canUseElevator = false;
    bool haveUsed = false;

    Vector3 textPos = new Vector3(0, 0, 0);

    // Use this for initialization
    void Start()
    {
        textCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange)
        {

            textCanvas.enabled = true;
            if (inRange && Input.GetButton("Fire1"))
            {
                GetComponent<AudioSource>().clip = awfulSound;
                GetComponent<AudioSource>().Play();
                print("You can use the elevator now");
                Destroy(pill);
                Destroy(pill2);
                inRange = false;
                textCanvas.enabled = false;
                canUseElevator = true;
            }
        }
    }

    //cite: User Danubian's Teleporter.cs on GitHub
    void OnTriggerEnter(Collider other)
    {
        if (!haveUsed)
        {
            print("Player has entered teleporter");
            inRange = true;
            Vector3 displacement = player.transform.position - this.transform.position;

            player.transform.position = Arrive_At.transform.position;
            player.transform.position += displacement;
            haveUsed = true;
        }
    }
}
