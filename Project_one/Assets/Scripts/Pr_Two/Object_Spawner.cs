using UnityEngine;

public class Object_Spawner : MonoBehaviour 
{

    [SerializeField] private int _numberToSpawn =1;
    [SerializeField] private GameObject _objectToSpawn;
   
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            int _currentChildCount = transform.childCount;
            for (int i = transform.childCount; i < _currentChildCount + _numberToSpawn; i++)
            {
                GameObject spawnedObject = Instantiate(_objectToSpawn, transform);
                spawnedObject.transform.localPosition = new Vector3(0, i, 0);
                spawnedObject.transform.localRotation = Quaternion.Euler(new Vector3(0, 30 * i, 0));
                /* spawnedObject.transform.localPosition = Vector3.zero;
                 spawnedObject.transform.localRotation = Quaternion.Euler(Vector3.zero);*/
                break;
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            int _currentChildCount = transform.childCount;
            while (_currentChildCount > 0) {
                Destroy(transform.GetChild(_currentChildCount-1).gameObject);
                _currentChildCount--;
            }


        }
        
    }
}
