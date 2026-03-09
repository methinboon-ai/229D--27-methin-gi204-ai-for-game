using UnityEngine;

public class Spaecship_BG_Flying : MonoBehaviour
{
    void Start()
    {
        ConstantForce force = GetComponent<ConstantForce>();
        force.relativeForce = new Vector3(0, 0, 10);
        force.relativeTorque = new Vector3(0, Random.Range(-15, 15), 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
