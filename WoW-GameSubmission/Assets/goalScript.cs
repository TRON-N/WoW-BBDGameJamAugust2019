using UnityEngine;

public class goalScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("exit");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
