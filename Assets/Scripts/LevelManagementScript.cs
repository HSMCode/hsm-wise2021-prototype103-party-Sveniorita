using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManagementScript : MonoBehaviour
{


    public GameObject player;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnCollisionEnter(Collision col) // check for Collision with Goal
    {
        if (col.gameObject.CompareTag("Goal")) // Check if Player collides with Finish (Tagged with Goal)
        {
            Debug.Log("WIN");
           // winPanel.SetActive(true); // show Winning Message
          //  player.SetActive(false); // hide the Player

        }





    }




}
