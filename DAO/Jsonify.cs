using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Net;
using System.Web.Script.Serialization;
using RDFRepresentation;
using ServiceStack.Text;


namespace DAO
{
	/**
	 * This class deals with JSON output based on triple list.
	 */
    public class Jsonify
    {
    	
    	/**
    	 * This method returns JSON string based on triple list.
    	 * 
		 * Example usage:
    	 * Console.WriteLine(Jsonify.me(myTripleList));
    	 * 
    	 * @param List<Triple>
	 	 * @return String
    	 */
    	public static String me(List<Triple> list) {
    		return JsonSerializer.SerializeToString(list);	
    	}
    	
    	//TODO: fill me
    	public static void toFile(dynamic @object, String file){
    		return ;
    	}
    	
    	/**
    	 * This method may fetch JSON from remote URL and
    	 * return dictionary.
    	 * 
		 * dynamic used, because thanks to that you can use any
    	 * of the JSON structure.
    	 * 
    	 * @param String url
    	 * @return dynamic Dictionary
    	 */ 
    	public static dynamic fromURL(String url) {
    		WebClient webClient = new WebClient();
			String content = webClient.DownloadString(url);

			JavaScriptSerializer jss = new JavaScriptSerializer();
			dynamic dict = jss.Deserialize<dynamic>(content);
			
			return dict;
    	}
    	
    	/**
    	 * This method returns String ready to be JSONIFIED
    	 * from some file.
    	 * 
    	 * @param String path to the file
    	 * @return String file content
    	 */ 
    	public static dynamic fromFile(String path) {
    		String data = File.ReadAllText(path);
    		return data;
    	}
    	
    	public static void Main() {
    		String content = fromFile("../../../data.json");
    		
			JavaScriptSerializer jss = new JavaScriptSerializer();
			dynamic dict = jss.Deserialize<dynamic>(content);
			
			foreach(dynamic row in dict["results"]["bindings"]){
				Console.WriteLine(row["film"]["value"]);
			}
			
			
    		/*
    		List<Triple> list = new List<Triple>();
    		
    		Entity obj = new Entity("Fort I", new EntityType("Zamek"));
    		Entity property = new Entity("zostalZbudowany", new EntityType("zostalZbudowany"));
    		Entity subject = new Entity("1922-1960", new EntityType("rok"));
    		
    		Triple t = new Triple(obj, property, subject);
    		list.Add(t);
    		
    		Console.WriteLine(JsonSerializer.SerializeToString(list));
    		*/
    		
    		Console.ReadKey();
    	}
    }
}
