using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public PlainBallPrefab ballPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            PlainBallPrefab ball = Instantiate<PlainBallPrefab>(ballPrefab);
            ball.transform.localPosition = transform.position;

            ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * Random.Range(500, 750));
        }
        
    }
}