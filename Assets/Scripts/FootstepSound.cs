using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    private AudioSource audioSource;

    public float footstepGapDistance = 1.0f;

    private Vector3 lastFootstepPosition;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        lastFootstepPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(lastFootstepPosition, transform.position) > footstepGapDistance)
        {
            audioSource.pitch = Random.Range(0.8f, 1.2f);
            audioSource.Play();
            lastFootstepPosition = transform.position;
        }
    }
}
