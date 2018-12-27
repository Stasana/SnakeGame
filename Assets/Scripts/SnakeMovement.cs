using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeMovement : MonoBehaviour
{

    public float Speed;

    public float RotationSpeed;

    public List<GameObject> tailObjects = new List<GameObject>();

    public float z_offset = 0.5f;

    public GameObject TailPrefab;

    public Text ScoreText;
    public int level = 0;
    public int score = 0;
    public Text highScore;

    // Use this for initialization
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        tailObjects.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = score.ToString();

        transform.Translate(Vector3.down * Speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-Vector3.forward * RotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.forward * RotationSpeed * Time.deltaTime);
        }
    }


    public void BonusPig()
    {
        Speed = Speed / 1.3f;
        StartCoroutine(TimerPig());
    }

    IEnumerator TimerPig()
    {
        yield return new WaitForSeconds(5);
        Speed = Speed * 1.3f;
    }

    public void BonusBird()
    {
        Speed = Speed * 1.3f;
        StartCoroutine(TimerBird());
    }

    IEnumerator TimerBird()
    {
        yield return new WaitForSeconds(5);
        Speed = Speed / 1.3f;

    }

    public void AddTail()
    {
        score++;
        level++;
        Vector3 newTailPos = tailObjects[tailObjects.Count - 1].transform.position;
        newTailPos.z -= z_offset;
        tailObjects.Add(GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);

        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }

        //New level - new speed.
        //Level 2
        if (level == 5)
        {
            Speed = Speed * 1.1f;
        }

        //Level 3
        if (level == 14)
        {
            Speed = Speed * 1.1f;
        }

        //Level 4
        if (level >= 28 & level < 31)
        {
            Speed = Speed * 1.1f;
        }

        //Level 5
        if (level >= 47 & level < 51)
        {
            Speed = Speed * 1.1f;
        }

        //Level 6
        if (level >= 71 & level < 76)
        {
            Speed = Speed * 1.1f;
        }

        //Level 7
        if (level >= 100 & level < 106)
        {
            Speed = Speed * 1.1f;
        }

        //Level 8
        if (level >= 134 & level < 141)
        {
            Speed = Speed * 1.1f;
        }

        //Level 9
        if (level >= 173 & level < 181)
        {
            Speed = Speed * 1.1f;
        }

        //Level 10
        if (level >= 217 & level < 226)
        {
            Speed = Speed * 1.1f;
        }


        // Every 5 apples = 1 level up > more score.
        if (level > 5 || score > PlayerPrefs.GetInt("HighScore", 0))
        {
            score++;
            level++;
            PlayerPrefs.SetInt("HighScore", score);
        }
        if (level > 15 || score > PlayerPrefs.GetInt("HighScore", 0))
        {
            score++;
            level++;
            PlayerPrefs.SetInt("HighScore", score);
        }
        if (level > 30 || score > PlayerPrefs.GetInt("HighScore", 0))
        {
            score++;
            level++;
            PlayerPrefs.SetInt("HighScore", score);
        }
        if (level > 50 || score > PlayerPrefs.GetInt("HighScore", 0))
        {
            score++;
            level++;
            PlayerPrefs.SetInt("HighScore", score);
        }
        if (level > 75 || score > PlayerPrefs.GetInt("HighScore", 0))
        {
            score++;
            level++;
            PlayerPrefs.SetInt("HighScore", score);
        }
        if (level > 105 || score > PlayerPrefs.GetInt("HighScore", 0))
        {
            score++;
            level++;
            PlayerPrefs.SetInt("HighScore", score);
        }
        if (level > 140 || score > PlayerPrefs.GetInt("HighScore", 0))
        {
            score++;
            level++;
            PlayerPrefs.SetInt("HighScore", score);
        }
        if (level > 180 || score > PlayerPrefs.GetInt("HighScore", 0))
        {
            score++;
            level++;
            PlayerPrefs.SetInt("HighScore", score);
        }
        if (level > 225 || score > PlayerPrefs.GetInt("HighScore", 0))
        {
            score++;
            level++;
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}