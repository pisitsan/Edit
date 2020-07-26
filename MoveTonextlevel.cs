using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveTonextlevel : MonoBehaviour
{
    public int Nextsceneload;
    // Start is called before the first frame update
    void Start()
    {
        Nextsceneload = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(Nextsceneload);

            if(Nextsceneload > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", Nextsceneload);
            }
        }
    }
}
