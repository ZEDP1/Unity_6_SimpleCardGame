using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class MoveCard : MonoBehaviour
{
    Rigidbody2D my_rigid;
    Vector3 my_position;
    Vector3 goal_position;
    Vector3 next_position;


    [SerializeField]
    public GameObject goal;


    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        
        next_position = goal.transform.position- transform.position;
        transform.position = Vector3.MoveTowards(transform.position, goal.transform.position, 3 * Time.deltaTime);



    }
}
