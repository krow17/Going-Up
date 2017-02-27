using UnityEngine;
using System.Collections;

public class PillTester2 : MonoBehaviour
{

    public bool inRange = false;
    public bool haveTaken = false;
    public Light_Flicker lf;
    public Light light;
    public GameObject pill;
    public Canvas canvas;

    // Use this for initialization
    void Start()
    {
        lf = GameObject.FindGameObjectWithTag("Pill_Light_3").GetComponent<Light_Flicker>();
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange)
        {
            canvas.enabled = true;

            if (inRange && Input.GetButton("Fire1"))
            {
                Destroy(pill);
                haveTaken = true;
                lf.enabled = false;
                light.enabled = true;
                inRange = false;
                canvas.enabled = false;
            }
        }

    }

    void OnTriggerEnter(Collider other)
    {
        inRange = true;

    }
}