using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Game/GameConfig")]
public class GameConfig : ScriptableObject
{
    [Header("Drag Settings")]
    public float dragThreshold = 0.1f;
    
    [Header("Timing")]
    public float autoAdvanceDelay = 2f;
    
    [Header("Audio")]
    public AudioClip successSound;
    public AudioClip errorSound;
    
    [Header("Scoring")]
    public int pointsPerMatch = 10;
}