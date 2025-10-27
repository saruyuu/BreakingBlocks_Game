using UnityEngine;
using UnityEngine.InputSystem;

public class StageManager : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;

    private bool started = false; 
    

    void Update()
    {
      
        if (!started && Keyboard.current.enterKey.wasPressedThisFrame)
        {
            Instantiate(ballPrefab, Vector3.zero, Quaternion.identity); ;   
            started = true;     
        }
    }
}