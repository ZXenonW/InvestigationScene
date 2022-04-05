using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    public float speed = 10.0f;
    AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        audioData = GetComponent<AudioSource>();
        //audioData.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.velocity.magnitude >= 10f && audioData.isPlaying == false)
        {
            audioData.volume = Random.Range(0.8f, 1);
            audioData.pitch = Random.Range(0.8f, 1.1f);
            audioData.Play();
        }

    }
}
