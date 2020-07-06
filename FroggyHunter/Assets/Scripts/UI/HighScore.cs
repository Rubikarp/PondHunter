using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public int _score = 0;
    public TextMeshProUGUI score;
    public TextMeshProUGUI highScore;

    public bool isInGame = true;
    public ParticleSystem particleScore;


    void Start()
    {
        if(highScore != null)
        {
            highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString("000 000");
            score.text = PlayerPrefs.GetInt("Score", 0).ToString("000 000");
        }

        scoreChange(0);
    }

    public void scoreChange(int point)
    {
        _score += point;
        if (isInGame) { particleScore.Play(true); }

        PlayerPrefs.SetInt("Score", _score);

        if (_score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", _score);
        }

        if (score != null)
        {
            score.text = _score.ToString("000 000");
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

