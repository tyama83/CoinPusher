using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    float speed = 2.0f;
    Rigidbody rb;

    public GameObject coin;

    public GameObject leftSideLimit;
    public GameObject rightSideLimit;
    float leftSideLimitPositionX;
    float rightSideLimitPositionX;

    public GameObject scoreText;
    ScoreScript scoreS;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        leftSideLimitPositionX = leftSideLimit.transform.position.x;
        rightSideLimitPositionX = rightSideLimit.transform.position.x;

        scoreS = scoreText.GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = this.transform.position;
        currentPosition.x = Mathf.Clamp(currentPosition.x,
                                        leftSideLimitPositionX,
                                        rightSideLimitPositionX);
        this.transform.position = currentPosition;

        float x = Input.GetAxis("Horizontal");

        Vector3 direction = new Vector3(x, 0, 0);

        rb.velocity = direction * speed;

        if (Input.GetKeyDown("space")) {
            Instantiate(coin, this.transform.position, this.transform.rotation);
            scoreS.addScore(-1);
        }
    }
}
