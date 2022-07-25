using ArthurYoshikawa_d3_avaliacao.Models.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArthurYoshikawa_d3_avaliacao.Models
{
    public class Logger : BaseLog
    {
        private string currentDirectory { get; set; }
        private string fileName { get; set; }
        public string filePath { get; set; }

        public Logger()
        {
            this.currentDirectory = Directory.GetCurrentDirectory();
            this.fileName = "Log.txt";
            this.filePath = $"{this.currentDirectory}/{fileName}";
        }

        public override void Log(string userId, string state)
        {
            using(StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine($"{userId};{DateTime.Now.ToString("HH:mm:ss")};{DateTime.Now.ToString("dd/MM/yyyy")};{state}");
            }
        }
    }
}
