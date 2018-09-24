using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerFlag : MonoBehaviour {
	
	public GameObject flagImage;
	public GameObject option1;
	public GameObject option2;
	public GameObject option3;
	public GameObject option4;
	
	string capitalOp1;
	string capitalOp2;
	string capitalOp3;
	string capitalOp4;
	
	string flag;
	int flagNumber;
	static int flagNumberStatic;
	string trueCapital;
	
	public List<string> capitals = new List<string>();
	public List<string> capitalsTaken = new List<string>();

	// Use this for initialization
	void Start () {
		capitals.Add("Warsaw");
		capitals.Add("Rome");
		capitals.Add("Paris");
		capitals.Add("Bucharest");
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	
	public void Randomer(){
		ResetColors();
		flagNumber = Random.Range(0,3);
		flagNumberStatic = flagNumber;
		Debug.Log(flagNumber);
		
		switch(flagNumberStatic){
			case 0:
				flag = "FlagPoland";
				LoadCountry(flag);
				Poland pl = new Poland();
				trueCapital = pl.GetCapital();
				SetCapital(trueCapital);
				break;
			case 1:
				flag = "FlagItaly";
				LoadCountry(flag);
				Italy it = new Italy();
				trueCapital = it.GetCapital();
				SetCapital(trueCapital);
				break;
			case 2:
				flag = "FlagRomania";
				LoadCountry(flag);
				Romania ro = new Romania();
				trueCapital = ro.GetCapital();
				SetCapital(trueCapital);
				break;
		}
	}
	
	void LoadCountry(string flag){
		Image img = flagImage.GetComponent<Image>();
		img.sprite = null;
		img.sprite = Resources.Load<Sprite>(flag) as Sprite;
	}
	
	void SetCapital(string capital){
		int opNumber = Random.Range(0,4);
		switch(opNumber){
			case 0:
				capitalsTaken.Clear();
				Option1(capital);
				Option2(FalseCapital());
				Option3(FalseCapital());
				Option4(FalseCapital());
				break;
			case 1:
				capitalsTaken.Clear();
				Option1(FalseCapital());
				Option2(capital);
				Option3(FalseCapital());
				Option4(FalseCapital());
				break;
			case 2:
				capitalsTaken.Clear();
				Option1(FalseCapital());
				Option2(FalseCapital());
				Option3(capital);
				Option4(FalseCapital());
				break;
			case 3:
				capitalsTaken.Clear();
				Option1(FalseCapital());
				Option2(FalseCapital());
				Option3(FalseCapital());
				Option4(capital);
				break;
		}
	
	}
	
	void Option1(string capital){
		Button btn = option1.GetComponent<Button>();
		Text txt = option1.transform.GetChild(0).gameObject.GetComponent<Text>();
		txt.text = capital;
		capitalOp1 = capital;
	}
	
	void Option2(string capital){
		Button btn = option2.GetComponent<Button>();
		Text txt = option2.transform.GetChild(0).gameObject.GetComponent<Text>();
		txt.text = capital;
		capitalOp2 = capital;
	}
	
	void Option3(string capital){
		Button btn = option3.GetComponent<Button>();
		Text txt = option3.transform.GetChild(0).gameObject.GetComponent<Text>();
		txt.text = capital;
		capitalOp3 = capital;
	}
	
	void Option4(string capital){
		Button btn = option4.GetComponent<Button>();
		Text txt = option4.transform.GetChild(0).gameObject.GetComponent<Text>();
		txt.text = capital;
		capitalOp4 = capital;
	}
	
	
	
	public void PolandCapitalOption1(){
		Image img = option1.GetComponent<Image>();
		bool isCorrect = PolandCapital(capitalOp1);
		if(isCorrect){
			img.color = Color.blue;
		}else{
			img.color = Color.red;
		}
	}
	
	public void PolandCapitalOption2(){
		Image img = option2.GetComponent<Image>();
		bool isCorrect = PolandCapital(capitalOp2);
		if(isCorrect){
			img.color = Color.blue;
		}else{
			img.color = Color.red;
		}
	}
	
	public void PolandCapitalOption3(){
		Image img = option3.GetComponent<Image>();
		bool isCorrect = PolandCapital(capitalOp3);
		if(isCorrect){
			img.color = Color.blue;
		}else{
			img.color = Color.red;
		}
	}
	
	public void PolandCapitalOption4(){
		Image img = option4.GetComponent<Image>();
		bool isCorrect = PolandCapital(capitalOp4);
		if(isCorrect){
			img.color = Color.blue;
		}else{
			img.color = Color.red;
		}
	}
	
	bool PolandCapital(string capital){
		if(capital == trueCapital){
			return true;
		}else{
			return false;
		}
			
	}
	
	string FalseCapital(){
		int numToAdd = Random.Range(0,capitals.Count);

		while(capitalsTaken.Contains(capitals[numToAdd]) || capitals[numToAdd] == trueCapital){
			numToAdd = Random.Range(0,capitals.Count);
			
		}
		
		capitalsTaken.Add(capitals[numToAdd]);
		return capitals[numToAdd];
		
		return null;
	}
	
	void ResetColors(){
		Image img1 = option1.GetComponent<Image>();
		img1.color = Color.white;
		Image img2 = option2.GetComponent<Image>();
		img2.color = Color.white;
		Image img3 = option3.GetComponent<Image>();
		img3.color = Color.white;
		Image img4 = option4.GetComponent<Image>();
		img4.color = Color.white;
	}
	
}
