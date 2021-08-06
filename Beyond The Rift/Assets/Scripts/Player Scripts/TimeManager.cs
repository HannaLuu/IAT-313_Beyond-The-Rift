using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float slowdownFactor = 0.4f;

    public void UndoSlowMotion()
    {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }

    public void DoSlowMotion()
    {
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }
}
