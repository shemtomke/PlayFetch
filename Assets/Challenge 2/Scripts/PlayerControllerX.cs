using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    bool dogSpawn;

    private float spawnInterval = 1.2f;
    private void Start()
    {
        dogSpawn = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && dogSpawn == false)
        {
            StartCoroutine(SpawnDog());
        }
    }

    IEnumerator SpawnDog()
    {
        //set the bool to true true
        dogSpawn = true;

        //instantiate the dog
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

        //after some interval time
        yield return new WaitForSeconds(spawnInterval);
        
        //set the the bool back to false
        dogSpawn = false;
    }
}
