using System;
using System.Windows.Forms;

namespace Controller.Exceptions
{
    internal class FieldErrorException : Exception
    {
        public FieldErrorException() : base("Se detectaron campos incorrectos.")
        {
            MessageBox.Show(Message);
        }

        public FieldErrorException(string msg) : base(msg)
        {
            MessageBox.Show(Message);
        }
    }
}
