using Controller.Exceptions;
using System.Linq;

namespace Controller.Verifies
{
    enum FormatType
    {
        LetterFormat,
        NumericFormat
    }

    internal sealed class Verify
    {
        private Verify() { }

        public static void VerifyText(params string[] fields)
        {
            foreach (var field in fields)
                if (string.IsNullOrEmpty(field))
                    throw new FieldErrorException();
        }

        public static void VerifyLogic(bool logic, string msg)
        {
            if (logic)
                throw new FieldErrorException(msg);
        }

        public static void VerifyFormat(string value, FormatType format)
        {
            if (value.All(char.IsLetter) &&
                format == FormatType.NumericFormat)
                throw new FieldErrorException("El campo " + 
                    value + "no tiene el formato adecuado. Solo escriba letras.");
            
            else if (value.All(char.IsDigit) &&
                format == FormatType.LetterFormat)
                throw new FieldErrorException("El campo " + 
                    value + "no tiene el formato adecuado. Solo escriba números.");
        }
    }
}
