using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    public static DatabaseManager Instance;

    public GameEvent connectingGameEvent;
    public GameEvent connectionSuccessGameEvent;
    public GameEvent connectionFailedGameEvent;


    private void Awake()
    {
        Instance = this;
    }
}
