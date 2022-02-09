using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{

    public float movementSpeed;

    public GameObject player;

    public Transform spawnPoint; // Position where the player should respawn


    //Health Bar
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //When Button is pressed
        if (Input.GetKey(KeyCode.Space))
        {
            //Player Movement when Button is pressed
            transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
        }
 
    }



    //Detect collisions between the GameObjects with Colliders attached
    private void OnCollisionEnter(Collision collision)
    {

        //Check if Player collides with Guests (Tagged with Guest)
        if (collision.gameObject.tag == "Guest")
        {

            player.transform.position = spawnPoint.transform.position; // Reset Player Position
                                                             
            //Take Damage when Player hits Guest
            TakeDamage(25);

        }


        if (currentHealth <= 0)
        {
            //restart the scene when Health Bar expired
            SceneManager.LoadScene("06_Lost Panel");
        }


        // Check if Player collides with Finish (Tagged with Goal)
        if (collision.gameObject.tag == "Goal") 
        {
            // Start next Scene when player reaches Goal
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }

    }

    
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }


    }
