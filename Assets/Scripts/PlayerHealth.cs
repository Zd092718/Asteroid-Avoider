using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int playerHealth = 3;
    // Start is called before the first frame update
    public void Crash()
    {
        playerHealth--;
        if (playerHealth < 1)
        {
            gameObject.SetActive(false);
        }
    }
}
