using UnityEngine;
using KBEngine;
using System; 

public class UI_Chat : MonoBehaviour {
	bool showInput = false;
	UnityEngine.GameObject chatInputObj = null;
	
	void Awake ()     
	{
	}
	
	void Start () 
	{
		chatInputObj = UnityEngine.GameObject.Find("chatInput");
		NGUITools.SetActive(chatInputObj, false);
	}

	void Update()
	{
        if (Input.GetKeyUp(KeyCode.Return))
        {
        	onShowInput();
        }
	}
	
	void onShowInput()
	{
		showInput = !showInput;
		Common.DEBUG_MSG("UI_Chat::onShowInput: bool(" + showInput + ")!");
		NGUITools.SetActive(chatInputObj, showInput);
	}
	
	void OnMouseEnter ()
	{
	}
	
	void OnMouseOver ()
	{
	}
	
	void OnMouseExit ()
	{
	}
	
	public string getInput()
	{
		UnityEngine.GameObject chatInput = UnityEngine.GameObject.Find("chatInput");
		return chatInput.GetComponent<UIInput>().text;
	}
}
 