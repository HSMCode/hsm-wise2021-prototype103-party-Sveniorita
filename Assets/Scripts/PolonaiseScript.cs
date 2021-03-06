using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolonaiseScript : MonoBehaviour
{
    public Transform[] target;
    public float speed;

    private int current;

    public float damping = 6.0f;


    void FixedUpdate()
    {
        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position,target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
            var rotation = Quaternion.LookRotation(target[current].position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
        }

        else current = (current + 1) % target.Length;
    }
}
