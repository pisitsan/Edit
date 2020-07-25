using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Jump : MonoBehaviour
{
    Animator Anim;
    Rigidbody RB;
    public float Jumpheight;
    public bool CharacterOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetAxis("Jump") != 0 && CharacterOnGround)
        {
            Anim.SetBool("Jumping",true);
            RB.AddForce(new Vector3(0, Jumpheight, 0), ForceMode.Impulse);
            CharacterOnGround = false;
        }

        else if (CharacterOnGround)
        {
            Anim.SetBool("Jumping",false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Block")
        {
            if (RB.velocity.y < 0)
            {
                CharacterOnGround = true;
                Anim.SetBool("Jumping", false);
            }
            
        }

    }
}
