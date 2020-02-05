using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//Stopped at Writing the Game Manager, 5:55 -- did not make GameObject a prefab yet

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    private BoardManager boardScript; // Unity doesn't like this line for some reason?
    private int level = 3;
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (intstance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        boardScript = GetComponent<BoardManager>();
        InitGame();
    }

    void InitGame()
    {
        boardScript.SetupScene(level);
    }

    void Update()
    {

    }
}