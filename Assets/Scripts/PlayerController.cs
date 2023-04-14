using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //playerRb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float HorizontalMovement = Input.GetAxis("Horizontal");
        //if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) { transform.Translate(Vector3.right * Time.deltaTime);}
        //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) { transform.Translate(Vector3.left * Time.deltaTime);}
        Vector3 MoveBall = new Vector3(HorizontalMovement, 0, 0);
        gameObject.transform.GetComponent<Rigidbody>().AddForce(MoveBall * speed);
    }
}
