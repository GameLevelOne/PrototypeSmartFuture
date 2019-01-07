using System.Collections.Generic;

public enum AsetType{
	Bisnis,
	Emas,
	Properti,
	Reksadana,
	Tabungan,
	Saham,
	Unitlink
}

[System.SerializableAttribute]
public struct Aset{
	public AsetType asetType;
	public string name;
	public int nilai;
	public int harga;
	public int pemasukan;
	public int jumlah;
}

[System.SerializableAttribute]
public struct Cicilan{
	public string name;
	public int jumlah;
	public int biayaCicil;
}


public class GameData {
	public GameData(string name, string email, string table)
	{
		playerName = name;
		playerEmail = email;
		playerTable = table;

		kas = 35000000;
		gaji = 10000000;
		biayaHidup = 5000000;
		sewaApartemen = 1000000;
		biayaTransport = 500000;
	}

	public string playerName;
	public string playerEmail;
	public string playerTable;
	
	public long kas;
	public int gaji;
	public int biayaHidup;
	
	public int sewaApartemen;
	public int biayaTransport;

	public List<Aset> aset = new List<Aset>();
	public List<Cicilan> cicilan = new List<Cicilan>();
}
