using System;
using System.IO;

namespace SuperNotUnderstandableInputHandling
{
    public class InputFile : InputParam<string>
    {
        public InputFile(string name, string description, bool mustExist)
            : base(name, description, (file) =>
            {
                if (mustExist && !File.Exists(file))
                {
                    throw new Exception($"File {file} does not exist");
                }
                return file;
            })
        {
        }
    }
}