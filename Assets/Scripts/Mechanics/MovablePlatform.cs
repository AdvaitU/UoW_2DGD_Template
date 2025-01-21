using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class MovablePlatform : MonoBehaviour
{

    public float speed = 1.5f;
    public int startingPoint;
    public Transform[] points;

    private int i = 0;

    private void Start()
    {
        transform.position = points[startingPoint].position;
    }



    void Update()
    {
        if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {
            i++;
            if (i == points.Length) i = 0;

        }
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponentInChildren<Transform>().position.y > transform.position.y && 
            collision.gameObject.tag == "Player") 
                collision.transform.SetParent(transform);
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }


    private void OnDrawGizmos()
    {

        for (int i = 1; i < points.Length; i++)
            if (points[i] != null) 
                Gizmos.DrawLine(points[i - 1].position, points[i].position);

    }
}

