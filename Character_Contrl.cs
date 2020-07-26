using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Contrl : MonoBehaviour
{
    AudioSource audioSRC;
    Animator Anim;
    public CharacterController controller;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 1f;
        Anim = GetComponent<Animator>();
        
        audioSRC = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        float horizontal = Input.GetAxisRaw("Horizontal");
        if(Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1f)
        {
            Anim.SetFloat("Walk", Mathf.Abs(Input.GetAxis("Horizontal")));

            //Audio

            if(!audioSRC.isPlaying)
            audioSRC.Play();
        }

        else if (Mathf.Abs(Input.GetAxis("Vertical")) > 0.1f)
        {
            Anim.SetFloat("Walk", Mathf.Abs(Input.GetAxis("Vertical")));

            //Audio

            if (!audioSRC.isPlaying)
                audioSRC.Play();
        }

        else
        {
            Anim.SetFloat("Walk", 0);

            //Stop Audio

            audioSRC.Stop();
        }

        /////////////////////////////////////////////////
        

        float vertical = Input.GetAxisRaw("Vertical");
        //Rotate Character
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
            

            controller.Move(direction * moveSpeed * Time.deltaTime);
        }
    }
}
