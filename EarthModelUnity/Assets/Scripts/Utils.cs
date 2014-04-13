// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;
using System;
using System.IO;
using SimpleJSON;

namespace Utilities{
	public class Utils
	{
		/**
		 * file is in StreamAssets folder 
		 */
		public static string GetAssest(string filename)
		{
			return System.IO.Path.Combine(Application.streamingAssetsPath, filename);
		}

		public static string ReadTextFile(string filename)
		{
			string filePath = GetAssest(filename);
//			if (filePath.Contains("://")) {
//				WWW www = new WWW(filePath);
//				yield return www;
//				return www.text;
//			} else
				return System.IO.File.ReadAllText(filePath);
		}

		public static byte[] ReadBinaryFile(string filename)
		{
			return System.IO.File.ReadAllBytes(GetAssest(filename));
		}

		public static JSONNode ReadJSonFile(string filename)
		{
			string str = ReadTextFile(filename);
			return JSON.Parse(str);
		}

		public static JSONNode ConvertJson(string jsonstring)
		{
			return JSON.Parse(jsonstring);
		}

		public static JSONNode ConvertJson(byte[] buffer)
		{
			string str = System.Text.Encoding.Default.GetString(buffer);
			return JSON.Parse(str);
		}
	}
}