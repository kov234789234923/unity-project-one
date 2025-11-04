using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour 
{
    public int scoreValue;
    public Text scoreText;
    [SerializeField] private CameraSwitch cameraSwitch;
 

    private void Start()
    {

        scoreText = GetComponent<Text>();
        scoreText.text = "Score:" + scoreValue.ToString();
    }

    private void Update()

    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (cameraSwitch.isMainCamera)
            {
                scoreValue++;
                scoreText.text = "Score:" + scoreValue.ToString();

                switch (scoreValue)
                {
                    case 15:
                        scoreText.color = Color.blue; 
                        break;
                    /*default:
                        scoreText.color=Color.brown; break;*/
                }

                if (scoreValue >= 0 && scoreValue <= 10)
                {
                    scoreText.color = Color.red;
                }
                else if (scoreValue == 50 || scoreValue == -50)
                {
                    scoreText.color = Color.white;
                }
                else if (scoreValue > 10 && scoreValue != 15)
                {
                    scoreText.color = Color.green;
                }
                else
                {
                    scoreText.color = Color.purple;
                }
            }
            


        else
            {
                scoreValue--;
                scoreText.text = "Score:" + scoreValue.ToString();

                if (scoreValue >= 0 && scoreValue <= 10)
                {
                    scoreText.color = Color.red;
                }
                else if (scoreValue == 50 || scoreValue == -50)
                {
                    scoreText.color = Color.white;
                }
                else if (scoreValue < 0)
                {
                    scoreText.color = Color.pink;
                }
                else
                {
                    scoreText.color = Color.yellow;
                }
            }
        } }
    }

