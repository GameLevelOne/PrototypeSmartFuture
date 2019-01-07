using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour {
	private static PlayerData instance;
	public static PlayerData Instance{
		get{ return instance;}
	}

	void Awake()
	{
		if(instance != null && instance != this){
			Destroy(gameObject);
		}else{
			instance = this;
		}
		DontDestroyOnLoad(gameObject);
	}

	GameData gameData;

	public string PlayerName
	{
		get{ return gameData.playerName; }
	}
	public string PlayerEmail
	{
		get{ return gameData.playerEmail; }
	}
	public string PlayerMeja
	{
		get{ return gameData.playerTable; }
	}

	public int Gaji{
		get{ return gameData.gaji; }
	}

	public List<Aset> aset{
		get{ return gameData.aset; }
	}
	public List<Cicilan> cicilan{
		get{ return gameData.cicilan; }
	}

	public int BiayaHidup{
		get{return gameData.biayaHidup; }
		
	}
	public int BiayaTransport{
		get{return gameData.biayaTransport; }
		set{gameData.biayaTransport = value; }
	}
	public int SewaApartemen{
		get{return gameData.sewaApartemen; }
		set{ gameData.sewaApartemen = value; }
	}

	public void InitGameData(string name, string email, string meja)
	{
		gameData = new GameData(name,email,meja);
	}
}
