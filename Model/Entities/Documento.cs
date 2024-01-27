namespace Model.Entities
{
    public class Documento
    {
        public Documento() { }

        public Documento
            (string tipoDocumento, string numeroDocumento)
        {
            this.tipoDocumento = tipoDocumento;
            this.numeroDocumento = numeroDocumento;
        }

        private string tipoDocumento;
        private string numeroDocumento;

        public string TipoDocumento { get { return tipoDocumento; } set { tipoDocumento = value; } }
        public string NumeroDocumento { get { return numeroDocumento; } set { numeroDocumento = value; } }

        public bool SameDocumento(Documento documento)
        {
            return
            tipoDocumento.Equals(documento.TipoDocumento) &&
            numeroDocumento.Equals(documento.NumeroDocumento);
        }
    }
}
