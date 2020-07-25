using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Pull : MonoBehaviour
{
    public bool CharacterOnGround = true;
    // Start is called before the first frame update
    private void OnCollisionStay(Collision obj)
    {
        if (obj.gameObject.tag == "Block")
        {
            if (Input.GetKey(KeyCode.LeftControl))
            {
                obj.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            }
            else
            {
                obj.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            }
        }
    }

    private void OnCollisionExit(Collision obj)
    {
        if (obj.gameObject.tag == "Block")
        {
            obj.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }

   
}
