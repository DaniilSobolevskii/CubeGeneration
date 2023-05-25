using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour
{

    [SerializeField] private float _recolourDuration;
    [SerializeField] private float _pauseTime;

    private Color _startColor;
    private Color _nextColor;
    private Renderer _renderer;

    private float _recolourTime;
    
    
    
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        GetNextColour();
    }

    private void GetNextColour()
    {
        _startColor = _renderer.material.color;
        _nextColor = Random.ColorHSV();
    }

    // Update is called once per frame
    void Update()
    {
        _recolourTime += Time.deltaTime;
        
        _renderer.material.color = Color.Lerp(_startColor, _nextColor, (_recolourTime/_recolourDuration));

        if (_recolourTime >= _recolourDuration + _pauseTime)
        {
            _recolourTime = 0;
            GetNextColour();
        }
        
    }
}
