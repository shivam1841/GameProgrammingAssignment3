using UnityEngine;
using System.Collections;

public class HeroController : MonoBehaviour
{
    //private variables declaration
    private Animation _animation;
    private float _movement;
    private float _charge;

    // Use this for initialization
    void Start()
    {
        this._animation = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
