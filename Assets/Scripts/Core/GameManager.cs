using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    [SerializeField] private GameConfig gameConfig;
    
    public GameState CurrentState { get; private set; }
    public GameConfig Config => gameConfig;
    
    private void Awake()
    {
        // Singleton pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            CurrentState = GameState.Boot;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    private void Start()
    {
        Debug.Log("Game Manager initialized");
        TransitionTo(GameState.ThemeSelect);
    }
    
    public void TransitionTo(GameState newState)
    {
        Debug.Log($"State transition: {CurrentState} -> {newState}");
        CurrentState = newState;
        
        // Handle state-specific logic later
    }
}