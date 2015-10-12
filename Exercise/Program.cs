using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DirectoryName = "AppProfileOptimization";
            const string ProfileFile = "AppProfile";

            if (!Directory.Exists(DirectoryName))
            {
                Directory.CreateDirectory(DirectoryName);
            }

            ProfileOptimization.SetProfileRoot(DirectoryName);
            ProfileOptimization.StartProfile(ProfileFile);
        }
    }
}
