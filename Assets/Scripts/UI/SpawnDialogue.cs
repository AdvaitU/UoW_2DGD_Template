using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDialogue : MonoBehaviour
{
    bool spawned = false;
    public GameObject dialogueObject;

    void Start()
    {
        dialogueObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            dialogueObject.SetActive(!spawned);
            spawned = !spawned;
        }
            
    }
}
