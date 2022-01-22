using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public BallPrefab ballPrefab;
    public int force = 100;
    public TargetPrefab targetPrefab;
    float nextTime = 0;
    public int interval = 3;
    GameObject scoreBoard;
    int hits = 0;
    int misses = 0;

    // Start is called before the first frame update
    void Start()
    {
        nextTime = Time.time + interval;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTime) {
            nextTime += interval;
            var targets = FindObjectsOfType<TargetPrefab>();
            if (targets.Length < 10) {
                Instantiate(targetPrefab);
            }
        }
        if (Input.GetMouseButtonDown(0)) {
            BallPrefab ball = Instantiate<BallPrefab>(ballPrefab);
            ball.transform.localPosition = transform.position;

            ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * force);
        }
    }

    public void hit(){ 
        hits++;
        updateScore();
    }
    
    public void miss(){ 
        misses++;
        updateScore();
    }

    void updateScore(){ 
        if (scoreBoard == null) {
            scoreBoard = GameObject.Find("Score Board");
        }
        if ((hits + misses) == 0) {
            scoreBoard.GetComponent<TextMesh>().text = "Score: " + 0 + " Miss: " + 0 + " Accuracy: " + 0 + "%"; 
        } else {
            scoreBoard.GetComponent<TextMesh>().text = "Score: " + hits + " Miss: " + misses + " Accuracy: " + (100.0 * hits / (hits + misses)).ToString("n2") + "%";
        }
    }
}
