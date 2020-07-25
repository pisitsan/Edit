using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    
    Animator Anim;
    public void Start()
    {
        Anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnpoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            Invoke("Reposition",1);
      
        
                  
        //Anim.SetBool("Death", true);
    }

    private void Reposition()
    {
        player.transform.position = respawnpoint.transform.position;
    }
}