using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endLevel : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player") {
            // TODO: uncomment and delete log once menu level exists
            //Application.LoadLevel("menu");
            Debug.Log("End of level");
        }
    }
}
