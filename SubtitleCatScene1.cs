using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubtitleCatScene1 : MonoBehaviour
{
	public string[] textSubtitle;

	public Text subtext;
	public float NextText;
	public int endVoice;
	private float timer;
	private int i;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void FixedUpdate()
	{
		subtext.text = textSubtitle[i];
		timer += 1 * Time.deltaTime;
		if (timer >= NextText)
		{
			i += 1;
			timer = 0;
		}
	}
}
