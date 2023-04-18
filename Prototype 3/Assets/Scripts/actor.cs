using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class actor : MonoBehaviour
{
    private Rigidbody playerrigid;
    public float jumpforce;
    public float gravityModifier;
    // Start is called before the first frame update
    void Start()
    {
        playerrigid = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerrigid.AddForce(Vector3.up * 10 * jumpforce, ForceMode.Impulse); // Increase jump force
        }
    }
}
