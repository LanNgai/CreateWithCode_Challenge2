using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float time = 1.0f;
    private float timer = 0f;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= time){//if statement to stop player from spamming
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                dogSpawner();
                timer = 0;
            }
        }
    }

    void dogSpawner (){
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}
