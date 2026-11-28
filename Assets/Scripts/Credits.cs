
using UnityEngine;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();

#if UNITY_EDITOR
        Debug.Log("Quit requested. Application.Quit does not close the Unity Editor.");
#endif
    }
}
