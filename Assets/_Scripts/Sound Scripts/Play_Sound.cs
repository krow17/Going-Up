using UnityEngine;
using System.Collections;

public class Play_Sound : MonoBehaviour {


    public AudioClip alertSound;

    bool inRange = false;
    bool havePlayed = false;

    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (inRange && !havePlayed)
        {
            float vol = Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(alertSound, vol);
            inRange = false;
            havePlayed = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        inRange = true;
    }

}
