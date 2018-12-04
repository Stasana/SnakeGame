﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeMovement : MonoBehaviour {

    public float Speed;

    public float RotationSpeed;

    public List<GameObject> tailObjects = new List<GameObject>();

    public float z_offset = 0.5f;

    public GameObject TailPrefab;

    public Text ScoreText;
    public int score = 0;

	// Use this for initialization
	void Start () {
        tailObjects.Add(gameObject);
	}
	
	// Update is called once per frame
	void Update () 
    {
        ScoreText.text = score.ToString();

        if(Input.GetKey(KeyCode.W))
        {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up*-1* RotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
    }
public  void AddTail()
{
        score++;
        Vector3 newTailPos = tailObjects[tailObjects.Count-1].transform.position;
        newTailPos.z -= z_offset;
        tailObjects.Add(GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);
}
    }