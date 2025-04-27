using UnityEngine;

public class StaticInput : MonoBehaviour
{
    private static PlayerInputActions instance;

    public static PlayerInputActions GetInstance()
    {
        if(instance == null)
        {
            instance = new PlayerInputActions();
        }
        return instance;
    }
}
