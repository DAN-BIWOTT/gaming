using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class login : MonoBehaviour {

	public string inputUsername;
	public string inputPassword;

	string LogInURL = "http://localhost/master's_table/login.php";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.L)) 
		{
		 StartCoroutine(loginToDB(inputUsername,inputPassword));
		}
	}

	IEnumerator loginToDB(string username, string password){
		WWWForm form = new WWWForm();

		form.AddField("usernamePost",username);
		form.AddField("passwordPost",password);

		WWW www = new WWW(LogInURL, form);
		yield return www;

		Debug.Log(www.text);
	}
}
