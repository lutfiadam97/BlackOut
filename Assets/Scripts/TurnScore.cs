using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnScore : MonoBehaviour
{
    public Text turn1;
    public int score;

    public void Turn()
    {
    	int number = score++;
    	turn1.text = number.ToString();
    }
}
