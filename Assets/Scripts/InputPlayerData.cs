using UnityEngine;
using UnityEngine.UI;

public class InputPlayerData : MonoBehaviour {
	public InputField inputFieldNama;
	public InputField inputFieldEmail;
	public InputField inputFieldMeja;


	public void ButtonSubmitOnClick()
	{
		PlayerData.Instance.InitGameData(inputFieldNama.text,inputFieldEmail.text,inputFieldMeja.text);
	}
}
