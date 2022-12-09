using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject player;
    public float speed = 10f;
    public float belok = 5f;
    private float kontrolBelok;
    private float kontrolJalan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        kontrolBelok = Input.GetAxis("Horizontal");
        kontrolJalan = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * kontrolJalan * speed);
        transform.Rotate(Vector3.up * Time.deltaTime * kontrolBelok * belok);

    }
}
