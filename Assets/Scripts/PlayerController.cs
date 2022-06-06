using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;

    public GameObject projectile;

    // Update is called once per frame
    void Update()
    {
        UpdatePosition();
        FireProjectile();
    }

    private void UpdatePosition()
    {
        if (transform.position.x < -xRange) {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        } else if (transform.position.x > xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
    }

    private void FireProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(projectile, transform.position, projectile.transform.rotation);
        }
    }
}
