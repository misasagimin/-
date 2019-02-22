using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    

    void FixedUpdate()
    {
        // 入力をxとzに代入
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // 同一のGameObjectがRigidbodyコンポーネントを取得
        Rigidbody rigibody = GetComponent<Rigidbody>();

        // Rigibodyのx軸（横）とz軸（奥）に力を加える
        rigibody.AddForce(x*4, 0, z*4);
    }


    private void Update()
    {
        //SceneManager.LoadScene("meiro o");
    }

    //ゴールに到着
    private void OnTriggerEnter(Collider other)
    {   //ミス判定
        if (other.gameObject.tag == ("Miss"))
        { SceneManager.LoadScene("meiro o"); }

        else
        {
            Debug.Log("ゴール！");
            SceneManager.LoadScene("meiro e");
        }
        
    }
}
