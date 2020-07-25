using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Die : MonoBehaviour
{
    Animator Anim;
    public void Start()
    {
        Anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
       private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Airdie")
        {
            Anim.SetBool("Die", true);

            Invoke("Reposition", 1);
        }
        //Anim.SetBool("Death", true);
    }
    private void Reposition()
    {
        Anim.SetBool("Die", false);
    }

}