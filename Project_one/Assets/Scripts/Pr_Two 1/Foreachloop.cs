using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.PlayerLoop;

public class Foreachloop : MonoBehaviour
{
    [SerializeField] private List<int> _intList;
    [SerializeField] private int[] _intArray = new int[] {6,7,8,9,10};

    private void Start()
    {
        _intList = new List<int>(new int[] { 1, 2, 3, 4});
        _intList.Add(5);
        _intList.AddRange(_intArray);
        _intList.Remove(10);
        _intList.RemoveAt(2);
        _intList.Clear();   
        foreach (int i in _intList)
        {
            Debug.Log(i);
        }
    }

    private void Update()
    {
        
    }
}
