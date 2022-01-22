using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallPrefab : MonoBehaviour
{
    private bool collided = false;
    public TargetPrefab targetPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other){
        if (!collided) {
            collided = true;
            Destroy(other.gameObject);
            Destroy(gameObject);
            Camera.main.GetComponent<MainCamera>().hit();
            // Instantiate(targetPrefab);
        }
    }

    private void OnDestroy(){
        if (!collided){
            Camera.main.GetComponent<MainCamera>().miss();
        }
    }

}
