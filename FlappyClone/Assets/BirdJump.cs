using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float jumpSize;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpSize;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Score.score > Score.bestScore)
        {
            Score.bestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
