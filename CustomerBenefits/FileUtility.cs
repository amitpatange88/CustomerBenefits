using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBenefits
{
    /// <summary>
    /// File Operations are handled here.
    /// </summary>
    public class FileUtility
    {
        private string _FileLocation = string.Empty;

        //Assigning objects here only immplies lazy loading in Singleton design pattern.
        private static readonly Lazy<FileUtility> instance = new Lazy<FileUtility>(() => new FileUtility());

        public static FileUtility Instance
        {
            get
            {
                return instance.Value;
            }
        }

        public FileUtility()
        {
        }

        public FileUtility(string filePath)
        {
            _FileLocation = filePath;
        }

        public string ReadFile()
        {
            CreateFileIfNotExists();

            string text = File.ReadAllText(_FileLocation);

            return text;
        }

        public bool WriteLog(string content)
        {
            bool IsDone = false;
            try
            {
                CreateFileIfNotExists();
                using (StreamWriter w = File.AppendText(_FileLocation))
                {
                    w.WriteLine(content);
                    IsDone = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return IsDone;
        }

        public bool ReplaceWithNewWrite()
        {
            bool IsDone = false;
            try
            {
                File.Delete(_FileLocation);
                IsDone = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return IsDone;
        }

        private void CreateFileIfNotExists()
        {
            bool IsExist = File.Exists(_FileLocation);
            if (!IsExist)
            {
                var file = File.Create(_FileLocation);
                file.Close();
            }
        }


        public string SerializeJSONData(Customers e)
        {
            Newtonsoft.Json.JsonSerializerSettings jss = new Newtonsoft.Json.JsonSerializerSettings();

            Newtonsoft.Json.Serialization.DefaultContractResolver dcr = new Newtonsoft.Json.Serialization.DefaultContractResolver();
            dcr.DefaultMembersSearchFlags |= System.Reflection.BindingFlags.NonPublic;
            jss.ContractResolver = dcr;

            var response = Newtonsoft.Json.JsonConvert.SerializeObject(e, jss);

            return response;
        }

        public string SerializeJSONDataNew(NewCustomers e)
        {
            Newtonsoft.Json.JsonSerializerSettings jss = new Newtonsoft.Json.JsonSerializerSettings();

            Newtonsoft.Json.Serialization.DefaultContractResolver dcr = new Newtonsoft.Json.Serialization.DefaultContractResolver();
            dcr.DefaultMembersSearchFlags |= System.Reflection.BindingFlags.NonPublic;
            jss.ContractResolver = dcr;

            var response = Newtonsoft.Json.JsonConvert.SerializeObject(e, jss);

            return response;
        }

        /// <summary>
        /// Serialize the JSON data. Using with Default contract resolver for non public fields.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public dynamic DeserializeJSONData<T>(string message)
        {
            Newtonsoft.Json.JsonSerializerSettings jss = new Newtonsoft.Json.JsonSerializerSettings();

            Newtonsoft.Json.Serialization.DefaultContractResolver dcr = new Newtonsoft.Json.Serialization.DefaultContractResolver();
            dcr.DefaultMembersSearchFlags |= System.Reflection.BindingFlags.NonPublic;
            jss.ContractResolver = dcr;

            var response = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(message);

            return response;
        }
    }
}
