using System.IO;

namespace Solid_Principles.SINGLE_RESPONSIBILITY_PRINCIPLE
{
    // Responsibility of this Class is to save entities in File
    public class PersistenceManager
    {
        public void SaveToFile<T>(T entity, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
            File.WriteAllText(filename, entity.ToString());
        }
    }
}