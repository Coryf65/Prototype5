using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    private Rigidbody targetRb = null;
    private float minSpeed = 12f;
    private float maxSpeed = 16f;
    private float maxTorgue = 10f;
    private float xRange = 4f;
    private float ySpawnPosition = -2f;

    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        FlingAndSpinObject();
    }

    private void FlingAndSpinObject()
    {
        targetRb.AddForce(Vector3.up * Random.Range(minSpeed, maxSpeed), ForceMode.Impulse);
        targetRb.AddTorque(Random.Range(-maxTorgue, maxTorgue), Random.Range(-maxTorgue, maxTorgue), Random.Range(-maxTorgue, maxTorgue), ForceMode.Impulse); // rotation, instant

        transform.position = new Vector3(Random.Range(-xRange, xRange), ySpawnPosition, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Player clicked this target
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        // we have a gameobject with a collider the only one
        // so once a target touches the "Sensor" delete it
        Destroy(gameObject);
    }
}
