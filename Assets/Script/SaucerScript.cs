using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaucerScript : MonoBehaviour
{
    public GameObject scoreText;
    ScoreScript scoreS;

    AudioSource getSE;

    private void Start()
    {
        scoreS = scoreText.GetComponent<ScoreScript>();
        getSE = this.GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            scoreS.addScore(2);
            getSE.PlayOneShot(getSE.clip);
        }
    }
}
