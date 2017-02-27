using UnityEngine;
using System.Collections;

public class Frantic_Violin : MonoBehaviour {

    public AudioClip franticViolin;
    AudioSource source;

    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    // Use this for initialization
    void Start ()
    {
        source = GetComponent<AudioSource>();
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        print(GameObject.FindGameObjectWithTag("To_Impossible").GetComponent<Teleporter_A>().haveUsed);
        if (GameObject.FindGameObjectWithTag("To_Impossible").GetComponent<Teleporter_A>().haveUsed == true)
        {
            float vol = Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(franticViolin, vol);
        }
	}
}
