using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastFiredAt;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var now = Time.time;
            
            if (now - lastFiredAt < 1.0f) {
                Debug.Log("Recently fired a dog");
                return;
            }
            
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastFiredAt = now;
        }
    }
}
