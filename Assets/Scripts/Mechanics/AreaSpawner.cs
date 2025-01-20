using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Mechanics;


[System.Serializable]
public struct SpawnableObject
{
    public GameObject objectToSpawn;
    public Vector3 atLocation;
    
}
public class AreaSpawner : MonoBehaviour
{
    private SpriteRenderer _sr;
    public bool hideOnStart = true;
    public SpawnableObject[] objectsToSpawn = new SpawnableObject[5];
    

    // Start is called before the first frame update
    void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
        if (hideOnStart) _sr.enabled = false;
    }

    private void OnApplicationQuit()
    {
        _sr.enabled=true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < objectsToSpawn.Length; i++)
            {
                if (objectsToSpawn[i].objectToSpawn != null)
                {
                    SpawnObject(i);
                }
            }
        }
    }

    private void SpawnObject(int i)
    {
        Instantiate(objectsToSpawn[i].objectToSpawn, this.transform.position + objectsToSpawn[i].atLocation, Quaternion.identity);
    }

}
