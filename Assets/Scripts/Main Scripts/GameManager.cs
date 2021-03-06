using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public GameManager _shared;
        
    
    public bool TurningRight
    {
        get => turningRight;
        set => turningRight = value;
    }
    private bool turningRight; //If true the player last move was to the right, else it was false
    // Start is called before the first frame update
    [SerializeField] private RandomCreator koalaSpawner;
    [SerializeField] private RandomCreator fireSpawner;
    [SerializeField] private Runner runner;
    [SerializeField] private TextMeshProUGUI scoreUI;
    [SerializeField] private float koalaEffectOnSpeed;
    [SerializeField] public float maxFires;
    [SerializeField] private ScoreHolder myScore;
    public int MyLife
    {
        get => myLife;
        set => myLife = value;
    }
    [SerializeField] private int myLife;

    public float CurFires
    {
        get => curFires;
        set => curFires = value;
    }
    private float curFires;

    public int Score
    {
        get => score;
        set => score = value;
    }


    private int score;
    void Start()
    {
        _shared = this;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (myLife == 0 || curFires >= maxFires)
        {
            GameOver();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void GotKoala()
    {
        koalaSpawner.AmountOfItem -= 1;
        score++;
        scoreUI.text = score.ToString();
        runner.OutsideVarSpeed += koalaEffectOnSpeed;
    }

    public bool Rotating()
    {
        return runner.Rotate != 0;
    }

    public void GameOver()
    {
        SceneManager.LoadScene(2);
        myScore.score = score;

    }
}
