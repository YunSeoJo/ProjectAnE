using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTSBuildingSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject _placeholderBuilding;
    private GameObject _placeholder;

    [SerializeField]
    private GameObject _building;

    private Vector3 _mousePosition;
    private float _previousX;
    private float _previousZ;

    private Building _buildingScript;

    private void Start()
    {
        _placeholder = Instantiate(_placeholderBuilding);
        _buildingScript = _placeholder.GetComponent<Building>();
    }

    private void Update()
    {
        _mousePosition = Input.mousePosition;

        Ray ray = Camera.main.ScreenPointToRay(_mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            float positionX = hit.point.x;
            float positionZ = hit.point.z;

            if (_previousX != positionX || _previousZ != positionZ)
            {
                _previousX = positionX;
                _previousZ = positionZ;

                _placeholder.transform.position = new Vector3(positionX, 0f, positionZ);
            }

            if (Input.GetMouseButtonUp(0))
            {
                if (_buildingScript.isBuildable)
                    Instantiate(_building, _placeholder.transform.position, Quaternion.identity);
            }
        }
    }
}