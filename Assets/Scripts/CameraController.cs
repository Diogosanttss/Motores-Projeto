using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform _t;
    [SerializeField]
    private Transform playerTransform;

    public float velocidade = 12f;

    void Start()
    {
       if(_t == null) _t = GetComponent<Transform>();
    }

    void Update()
    {
        StartCoroutine(AtualizarMovimento());
    }

    private IEnumerator AtualizarMovimento()
    {
        _t.position = new Vector3(
            playerTransform.gameObject.GetComponent<Transform>().position.x+(velocidade*Time.deltaTime),
            playerTransform.gameObject.GetComponent<Transform>().position.y,
            _t.transform.position.z);
        yield return new WaitForSeconds(1.0f);
    }
}
