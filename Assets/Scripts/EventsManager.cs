using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class EventsManager : MonoBehaviour
{
    public static EventsManager Instance;

    public List<GameEvent> gameEvents;

    private void Awake()
    {
        Instance = this;
    }
}
