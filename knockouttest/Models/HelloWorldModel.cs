using System.Web.Script.Serialization;
using DelegateDecompiler;
using Newtonsoft.Json;

namespace knockouttest.Models
{
    public class HelloWorldModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        [Computed]
        [ScriptIgnore]
        [JsonIgnore]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        //public Expression<Func<string>> FullName()
        //{
        //    return () => FirstName + " " + LastName;
        //}
    }

    
}