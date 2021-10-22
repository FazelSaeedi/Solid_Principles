using System;
using System.Collections.Generic;
using System.IO;

namespace Solid_Principles.SINGLE_RESPONSIBILITY_PRINCIPLE
{
public class Journal
    {
        private readonly List<string> entries = new List<string>();
        // just a counter for total # of entries
        private static int count = 0;

        public void AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
        }
        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        [Obsolete("Violates SRP")]
        // This method violates Single Responsibility Principle of Journal Class
        public void Save(string filename, bool overwrite = false)
        {
            File.WriteAllText(filename, ToString());
        }
    }
}