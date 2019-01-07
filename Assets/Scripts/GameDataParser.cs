using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class GameDataParser {
	/// <summary>
	/// Load Data saved in fileName.
	/// </summary>
	public static T Load<T>(string fileName) where T: class
	{
		if(File.Exists(fileName)){
			try{
				using (Stream stream = File.OpenRead(fileName))	{
					BinaryFormatter formatter = new BinaryFormatter();
					return formatter.Deserialize(stream) as T;
				}
			}
			catch (Exception e){
				Debug.Log(e.Message);
			}
		}else{
			Debug.Log("File does not exist!");
		}
		return default(T);
	}

	/// <summary>
	/// Save the specified fileName and data.
	/// </summary>
	public static void Save<T>(string fileName, T data) where T: class
	{
		using (Stream stream = File.OpenWrite(fileName)){
			BinaryFormatter formatter = new BinaryFormatter();
			formatter.Serialize(stream,data);
		}
	}

	//load and save command example
//	Serializer.Save<ExampleClass>(fileNameWithExtention,ExampleClass);
//	ExampleClass exampleClass = Serializer.Load<ExampleClass>(fileNameWithExtention));
}
