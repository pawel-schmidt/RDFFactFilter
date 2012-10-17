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
    	
    	//TODO: fill me to the end
    	public static dynamic fromURL(String url) {
    		WebClient webClient = new WebClient();
			String content = webClient.DownloadString(url);

			JavaScriptSerializer jss = new JavaScriptSerializer();
			dynamic dict = jss.Deserialize<dynamic>(content);
			return dict;
    	}
    	
    	//TODO: make use of me
    	public static dynamic fromFile(String path) {
    		//data.json
    		String data = File.ReadAllText(path);
    		return data;
    	}
    	
    	public static void Main(){
    	
    		String url ="http://dbpedia.org/sparql?default-graph-uri=http%3A//dbpedia.org&query=PREFIX%20owl%3A%20%3Chttp%3A//www.w3.org/2002/07/owl%23%3E%0APREFIX%20xsd%3A%20%3Chttp%3A//www.w3.org/2001/XMLSchema%23%3E%0APREFIX%20rdfs%3A%20%3Chttp%3A//www.w3.org/2000/01/rdf-schema%23%3E%0APREFIX%20rdf%3A%20%3Chttp%3A//www.w3.org/1999/02/22-rdf-syntax-ns%23%3E%0APREFIX%20foaf%3A%20%3Chttp%3A//xmlns.com/foaf/0.1/%3E%0APREFIX%20dc%3A%20%3Chttp%3A//purl.org/dc/elements/1.1/%3E%0APREFIX%20%3A%20%3Chttp%3A//dbpedia.org/resource/%3E%0APREFIX%20dbpedia2%3A%20%3Chttp%3A//dbpedia.org/property/%3E%0APREFIX%20dbpedia%3A%20%3Chttp%3A//dbpedia.org/%3E%0APREFIX%20skos%3A%20%3Chttp%3A//www.w3.org/2004/02/skos/core%23%3E%0ASELECT%20%3Ffilm%0D%0AWHERE%20%7B%20%3Ffilm%20%3Chttp%3A//purl.org/dc/terms/subject%3E%20%3Chttp%3A//dbpedia.org/resource/Category%3AFrench_films%3E%20%7D&format=application/sparql-results%2Bjson";
    		WebClient webClient = new WebClient();
			String content = webClient.DownloadString(url);
    		
			

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
