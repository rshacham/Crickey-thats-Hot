using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    void Start()
    {
        _shared = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GotKoala()
    {
        print(koalaSpawner.AmountOfItem);
        koalaSpawner.AmountOfItem -= 1;
        print(koalaSpawner.AmountOfItem);
    }

    public bool Rotating()
    {
        return runner.Rotate != 0;
    }
}
