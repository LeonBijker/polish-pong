using UnityEngine;

public class BallHitWallEffect : MonoBehaviour
{
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (!collision.gameObject.name.Contains("Player")) return;
        gameObject.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(Random.Range(0.2f,1f),Random.Range(0.2f,1f),Random.Range(0.2f,1f));
    }
}