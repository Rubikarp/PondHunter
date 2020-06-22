using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public int _score = 0;
    public Text score;
    public Text highScore;

    void Start()
    {
        if(highScore != null)
        {
            highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
            score.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        }
    }

    public void scoreChange(int point)
    {
        _score += point;
        PlayerPrefs.SetInt("Score", _score);

        if (_score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", _score);
        }

        if (score != null)
        {
            score.text = _score.ToString();
        }
    }

    public void ResetScore()
    {
        // Reset the score.
        PlayerPrefs.DeleteKey("Score");

        // Reset affichage
        if (score != null)
        {
            score.text = "0";
        }
    }

    public void Reset()
    {
        // Reset the score & the highscore.  
        PlayerPrefs.DeleteKey("Score");
        PlayerPrefs.DeleteKey("HighScore");

        // Reset affichage
        if (highScore != null)
        {
            highScore.text = "0";
        }
    }
}

