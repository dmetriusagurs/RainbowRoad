using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



    public class ScoreManager : MonoBehaviour
    {

        public Text Scoretext;
        public Text HiScoreText;

        public float ScoreCount;
        public float HiScoreCount;
        public float PointsperSec;

        public bool Pointsincreasing;

        // Use this for initialization
        void Start()
        {


        }

        // Update is called once per frame
        void Update()
        {

            ScoreCount += Assets.Scripts.Global.PointsperSec * Time.deltaTime;

            if(ScoreCount > HiScoreCount)
            {
                HiScoreCount = ScoreCount;
            }
            Scoretext.text = "Score: " + Mathf.Round(ScoreCount);
            HiScoreText.text = "High Score: " + Mathf.Round(HiScoreCount);

        }
    }

