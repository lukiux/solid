﻿using System;
using System.IO;

namespace SOLID.SRP
{
    public class FileSaver
    {
        public FileSaver()
        {
            
        }

        public void SaveToFile(string directoryPath, string fileName, WorkReport report)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());
        }
    }
}
