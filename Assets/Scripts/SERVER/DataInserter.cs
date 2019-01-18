using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataInserter : MonoBehaviour {

	public string inputUsername;
	public string inputPassword;
	public string inputEmail;
	public string inputNational_id;

	string CreateUserURL = "http://localhost/master's_table/insertUser.php";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) 
		CreateUser(inputUsername,inputPassword,inputEmail,inputNational_id);
	}

	public void CreateUser(string username, string password, string email,string national_id)
	{
		WWWForm form = new WWWForm();
		form.AddField("usernamePost",username);
		form.AddField("passwordPost",password);
		form.AddField("emailPost",email);
		form.AddField("national_idPost",national_id);

		WWW www = new WWW(CreateUserURL, form);
	}
}
