using UnityEngine;

public class AssignBallHitWallEffectScript : MonoBehaviour
{
    GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = FindFirstObjectByType<GameObject>();
        ball.AddComponent<BallHitWallEffect>();
    }
}
