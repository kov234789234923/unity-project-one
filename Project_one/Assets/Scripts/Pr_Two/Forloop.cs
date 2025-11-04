using UnityEngine;

public class Forloop : MonoBehaviour
{
    private void Start()
    {
        

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T)) {
            for (int i = 0; i < 20; i++)
            {
                if (i == 6)
                    continue;
                Debug.Log(i);

                if (i == 16)
                    break; 
            }
        }
    }
}
