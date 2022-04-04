using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance = null;
    
    [SerializeField] private Text _highScore;
    [SerializeField] private Text _textScore;
    [SerializeField] private Text _endScore;
    
    private int _topScore;
    
    public int TopScore
    {
        get => _topScore;
        set => _topScore = value;
    }
    
    private void Start()
    { 
        if (Instance == null) 
        { 
            Instance = this;
        }
        else if(Instance == this)
        { 
            Destroy(gameObject); 
        }
    }

    private void Update()
    {
        _highScore.text = PlayerPrefs.GetInt("High Score: ").ToString();
        _textScore.text = _endScore.text = _topScore.ToString();
    }
}
