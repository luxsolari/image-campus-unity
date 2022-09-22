using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMove : MonoBehaviour
{
    private Vector3 initialSpawnPos;
    public Vector3 positionChange;

    // Start is called before the first frame update
    void Start()
    {
        this.initialSpawnPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += this.positionChange;
        if (this.transform.position.x >= initialSpawnPos.x + 100)
        {
            this.transform.position = initialSpawnPos;
        }
    }
}
