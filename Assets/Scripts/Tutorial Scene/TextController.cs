﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
	public static int instructionIndex = 0;

	[SerializeField] GameObject instructionsGO;
	[SerializeField] private Text instructions;

	public static int signalStrength = 0;
	private bool done = false;
	
	// Use this for initialization
	void Start ()
	{
		State.instructionsArePlaying = true;
		
		InvokeRepeating("IncreaseSignalStrength", 2f, 0.1f);
	}
	
	// Update is called once per frame
	void Update () {
		
		instructions.text = "markwatney$ Establishing connection to Earth... \nmarkwatney$ Signal strength: " + signalStrength + "%";

		if (!IsInvoking("IncreaseInstructionIndex") && done)
		{
			InvokeRepeating("IncreaseInstructionIndex", 2f, 3f);
		}

		if (done)
		{
			instructions.text = State.instructions[instructionIndex];
		}

		if (Input.GetKey(KeyCode.Return) && !State.instructionsArePlaying)
		{
			SceneManager.LoadScene(2);
		}
	}

	void IncreaseSignalStrength()
	{
		System.Random rnd = new System.Random();
		int increaseRate = rnd.Next(0, 4);
		if (signalStrength + increaseRate <= 100)
		{
			signalStrength = signalStrength + increaseRate;
		}
		else
		{
			done = true;
		}
	}

	
	void IncreaseInstructionIndex()
	{
		
		if (instructionIndex != 17 && !skipBtnPressed.skipButtonHasBeenPressed)
		{
			State.instructionsArePlaying = true;
			instructionIndex++;
		}
		else 
		{
			State.instructionsArePlaying = false;
		}

		if (instructionIndex == 17)
		{
			State.instructionsArePlaying = false;
		}
	}
	
}
