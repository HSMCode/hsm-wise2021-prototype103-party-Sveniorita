using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerPongScript : MonoBehaviour
{

    public GameObject beerPongBall;

    public float timeToSpawn;
    private float currentTimeToSpawn;
        
   



    private void FixedUpdate()
    {

        if(currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }

        else
        {
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
        }

        
       


          }

    public void SpawnObject()
    {
        Instantiate(beerPongBall, transform.position, transform.rotation);
    }


}
