using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    public class ClickHandler : MonoBehaviour
        {
        [SerializeField] int score = 0;
        public Text scoreText;

        public void OnClick()
            {
            score++;
            }

        void Update()
            {
            scoreText.text = score.ToString();
            }
        }