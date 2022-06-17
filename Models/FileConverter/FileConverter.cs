using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FishingApp.Models.FileConverter
{
    public class FileConverter
    {
        public void FileWriter(string PersonData)
        {
            const string path = @"YOUR TXT FILE PATH";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(PersonData);
            file.Close();


        }

        public void JsonWriter(string name, string password)
        {

            const string path = @"[YOUR JSON FILE PATH]";
            UserInfo user = new UserInfo();
            user.UserName = name;
            user.password = password;

            
            string output = JsonConvert.SerializeObject(user);
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(output);
            file.Close();



        }
    }
}
