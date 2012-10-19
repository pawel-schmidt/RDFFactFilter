using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Net;
using System.Web.Script.Serialization;
//using ServiceStack.Text;
using Newtonsoft.Json;

using RDFRepresentation;
using Filtering;

namespace DAO {
    /**
     * This class deals with JSON output based on triple list.
     * @implements IInput
     */
    public class Jsonify : IInput, IOutput {

        /**
         * This method loads and deserializes triples from file
         * 
         * @param String filePath
         * @return List<Triple> list
         */
        public List<Triple> readTriples(string filePath) {
            String data = File.ReadAllText(filePath);
            List<Triple> list;

            try {
                list = JsonConvert.DeserializeObject<List<Triple>>(data);
            }
            catch (JsonReaderException) {
                list = new List<Triple>();
            }
            return list;
        }

        /**
         * This method loads and deserializes pattern triples from file.
         * 
         * @param String filePath
         * @return List<Triple> list
         */
        public List<Triple> readPatternTriples(string filePath) {
            return this.readTriples(filePath);
        }

        /**
         * This method loads and deserializes lex collections from file.
         * 
         * @param String filePath
         * @return List<LexCollection> list
         */
        public List<LexCollection> readLexicalizations(string filePath) {

            String data = File.ReadAllText(filePath);

            List<LexCollection> list;

            try {
                list = JsonConvert.DeserializeObject<List<LexCollection>>(data);
            }
            catch (JsonReaderException) {
                list = new List<LexCollection>();
            }
            return list;
        }


        /// <summary>
        /// Save triples to file.
        /// </summary>
        /// <param name="triples">Filtered triples to save.</param>
        /// <param name="filePath">Path to file for save.</param>
        public void save(List<Triple> triples, String filePath) {
            File.WriteAllText(filePath, serializeTriples(triples));
        }

        /**
         * This method returns serialized triple list into JSON
         * 
         * Example usage:
         * Console.WriteLine(Jsonify.serializeTriples(myTripleList));
         * 
         * @param List<Triple>
         * @return String
         */
        public static String serializeTriples(List<Triple> list) {
            return JsonConvert.SerializeObject(list, Formatting.Indented);
        }

        /**
         * This method fetches ANY json from remote URL and
         * returns dictionary of deserialized values.
         * 
         * dynamic used, because thanks to that you can use any
         * of the JSON structure.
         * 
         * @param String url
         * @return dynamic Dictionary
         */
        public static dynamic deserializeUniversalFromUrl(String url) {
            WebClient webClient = new WebClient();
            String content = webClient.DownloadString(url);

            JavaScriptSerializer jss = new JavaScriptSerializer();
            dynamic dict = jss.Deserialize<dynamic>(content);

            return dict;
        }

        /**
         * This method returns parsed data of ANY json format
         * from file.
         * 
         * @param String path to the file
         * @return String file content
         */
        public static dynamic deserializeUniversalFromFile(String path) {
            String data = File.ReadAllText(path);

            JavaScriptSerializer jss = new JavaScriptSerializer();
            dynamic dict = jss.Deserialize<dynamic>(data);
            return dict;
        }

        /**
         * Junkyard
         */
        public static void Main() {

            //DO NOT EVEN LOOK AT THIS MESS BELOW

            //    		String content = fromFile("../../../data.json");
            //    		
            //			JavaScriptSerializer jss = new JavaScriptSerializer();
            //			dynamic dict = jss.Deserialize<dynamic>(content);
            //			
            //			foreach(dynamic row in dict["results"]["bindings"]){
            //				Console.WriteLine(row["film"]["value"]);
            //			}


            /*List<Triple> triples = readTriples("../../../triples.json");
            foreach(Triple t in triples){
				
                Console.WriteLine(t.ToString());
            }*/
            /*Entity obj = new Entity("Fort I", new EntityType("Zamek"));
            Entity property = new Entity("zostalZbudowany", new EntityType("zostalZbudowany"));
            Entity subject = new Entity("1922-1960", new EntityType("rok"));
//    		
            Triple t = new Triple(obj, property, subject);
    		
            List<Triple> list = new List<Triple>();
            list.Add(t);
			
            File.WriteAllText("../../../triples.json", JsonConvert.SerializeObject(list,Formatting.Indented,
  new JsonSerializerSettings { }) );
    		
			
            String data = File.ReadAllText("../../../triples.json");
			
			
            List<Triple> dicto = JsonConvert.DeserializeObject<List<Triple>>(data);
            */
            //			
            //			List<LexCollection> lii = new List<LexCollection>();
            //			
            //			LexCollection l = new LexCollection("OpisPowstawaniaObiektu");
            //			l.Add("został zbudowany");
            //			l.Add("stworzono");
            //			lii.Add(l);
            //			

            //			HashSet<String> l = new HashSet<String>();


            //File.WriteAllText("../../../triples.json", JsonConvert.SerializeObject(lii,Formatting.Indented,
            //new JsonSerializerSettings { 
            //TypeNameHandling = TypeNameHandling.All,
            //		                                                                       //PreserveReferencesHandling = PreserveReferencesHandling.Objects
            //		                                                                       }) );



            //List<LexCollection> list = readLexicalizations("../../../triples.json");
            //			foreach(LexCollection tr in list){
            //				
            //				Console.WriteLine(tr.ToString());
            //			}
            //Console.WriteLine(dicto.ToString());


            List<Triple> list = new List<Triple>();

            Entity obj = new Entity("Fort I", new EntityType("Budowla"));
            Entity property = new Entity("zostalZbudowany", new EntityType("zostalZbudowany"));
            Entity subject = new Entity("1922-1960", new EntityType("rok"));


            Entity obj2 = new Entity("Colloseum", new EntityType("Budowla"));
            Entity property2 = new Entity("zostalZbudowany", new EntityType("zostalZbudowany"));
            Entity subject2 = new Entity("200 p.n.e", new EntityType("rok"));

            Triple t = new Triple(obj, property, subject);
            Triple t2 = new Triple(obj2, property2, subject2);
            list.Add(t);
            list.Add(t2);

            File.WriteAllText("../../../triples.json",
                              JsonConvert.SerializeObject(list, Formatting.Indented)
                // JsonSerializer.SerializeToString(list)
                             );
            //Console.WriteLine(JsonSerializer.SerializeToString(list));


            //Console.ReadKey();
        }
    }
}
