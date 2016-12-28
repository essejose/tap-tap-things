using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerBall : MonoBehaviour {


    public Text Score;
    public int cont;
    public int vel;

    private Rigidbody2D myBody;

    void Awake()
    {
        myBody = this.GetComponent<Rigidbody2D>(); 
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       Score.text = cont.ToString();
	}

    void OnMouseDown()
    {
        
        myBody.AddForce(new Vector2(vel * Random.Range(-10,10), 900 ));
        cont++;
        vel = vel + 5;
    }

   
}
