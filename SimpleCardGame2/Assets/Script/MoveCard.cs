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
        my_rigid = GetComponent<Rigidbody2D>();
        my_position = transform.position;

        goal_position = goal.transform.position;

        next_position = goal_position - my_position;
        
        
        Debug.Log("my_position : " + my_position);
        Debug.Log("goal_position : " + goal_position);
        Debug.Log("changeposition  :" + next_position);
        Debug.Log("next-position¿« normal : " + next_position.normalized);



    }

    // Update is called once per frame
    void Update()
    {
        

        transform.position = Vector3.MoveTowards(transform.position, goal_position, 3 * Time.deltaTime);



    }
}
