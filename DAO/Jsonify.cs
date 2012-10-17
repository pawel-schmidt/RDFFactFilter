using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

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
    	
//    	public static void Main(){
//    		
//    		List<Triple> list = new List<Triple>();
//    		
//    		Entity obj = new Entity("Fort I", new EntityType("Zamek"));
//    		Entity property = new Entity("zostalZbudowany", new EntityType("zostalZbudowany"));
//    		Entity subject = new Entity("1922-1960", new EntityType("rok"));
//    		
//    		Triple t = new Triple(obj, property, subject);
//    		list.Add(t);
//    		
//    		Console.WriteLine(JsonSerializer.SerializeToString(list));
//    		Console.ReadKey();
//    	}
    }
}
