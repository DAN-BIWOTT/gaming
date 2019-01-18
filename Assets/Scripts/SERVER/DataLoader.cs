using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLoader : MonoBehaviour {

	public string[] Info;

	// Use this for initialization
	IEnumerator Start () {
	
		WWW usersInfo = new WWW("http://localhost/master's_table/usersData.php");
		yield return usersInfo;
		string usersInfoString = usersInfo.text;
		print (usersInfoString);
		Info = usersInfoString.Split(';');
		print(GetDataValue(Info[0],"E-mail:"));
	}

    string GetDataValue(string data,string index){
    	string value = data.Substring(data.IndexOf(index)+index.Length);
    	if(value.Contains("|")) value = value.Remove(value.IndexOf("|"));
    	return value;
    }
	
}
