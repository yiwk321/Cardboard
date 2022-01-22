using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPrefab : MonoBehaviour
{
    public int direction = 0;
    public int speed = 20;
    public Vector3 vector;
    public int threshold = 5;
    private Vector3 startPosition;
    public int minRange = 10;
    public int maxRange = 20;
    public static bool first = true;
    float updateTime = 0;
    public int minYRange = 0;
    public int maxYRange = 5;
    // Start is called before the first frame update
    void Start()
    {
        if (first) {
            first = false;
            changeDirection(0);
        } else {
            transform.position = randomVector();
            changeDirection(Random.Range(0, 3));
            // transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.down, Camera.main.transform.rotation * Vector3.back);
        }
        startPosition = transform.position;
        speed = Random.Range(speed/4, speed);
        updateTime = Time.time;
        Destroy(gameObject, 15);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - updateTime < 5 && System.Math.Abs((startPosition - transform.position)[direction]) >= threshold) {
            vector = -1 * vector;
            updateTime = Time.time;
        }
        transform.Translate(vector * speed * Time.deltaTime); 
    }

    public void changeDirection(int direction){
        this.direction = direction;
        vector = getVector(direction);
    }

    Vector3 getVector(int direction){
        switch (direction)
        {
            case 0:
                return Vector3.right;
            case 1:
                return Vector3.forward;
            case 2:
                return Vector3.up;
            default:
                return Vector3.right;
        }
    }

    private int randomSign() { return Random.Range(0, 2) * 2 - 1; }

    private int randomRange(int min, int max) { return randomSign() * Random.Range(min, max); }

    private Vector3 randomVector() { return new Vector3(randomRange(minRange, maxRange), randomRange(minYRange, maxYRange), randomRange(minRange, maxRange)); }
}
