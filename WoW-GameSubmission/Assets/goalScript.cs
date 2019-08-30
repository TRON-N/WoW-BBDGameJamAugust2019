using UnityEngine;

public class goalScript : MonoBehaviour
{
    public UIManager uiManager;
    public Collider2D blockCollider;
    public Collider2D ballToIgnore;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreCollision(this.ballToIgnore, this.blockCollider);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
       uiManager.EndGame("BLUE");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionObject = collision.gameObject;

        Physics2D.IgnoreCollision(this.ballToIgnore, this.blockCollider);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
