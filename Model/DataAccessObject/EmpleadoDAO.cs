using Model.Connection;
using Model.Entities;
using Model.Builders;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System;

namespace Model.DataAccessObject
{
    public class EmpleadoDAO : IDataAccess<EmpleadoEntity>
    {
        private const string DeleteString =
            "DELETE FROM empleados " +
            "WHERE tipo_documento=@tipo_documento " +
            "AND numero_documento=@numero_documento;";

        public void Delete(EmpleadoEntity reg)
        {
            using (SqlCommand cmd = new SqlCommand(DeleteString, DataBase.Connection))
            {
                cmd.Parameters.AddWithValue("@tipo_documento", reg.Documento.TipoDocumento);
                cmd.Parameters.AddWithValue("@numero_documento", reg.Documento.NumeroDocumento);

                File.Delete(Data.Get("PathImg") + reg.Documento.TipoDocumento + reg.Documento.NumeroDocumento + ".jpeg");

                cmd.ExecuteNonQuery();
            }
        }

        private const string InsertString =
            "INSERT INTO empleados " +
            "(nombres, apellidos, cargo, salario, foto_perfil, fecha_nacimiento, fecha_ingreso, tipo_documento, numero_documento) VALUES " +
            "(@nombres, @apellidos, @cargo, @salario, @foto_perfil, @fecha_nacimiento, @fecha_ingreso, @tipo_documento, @numero_documento);";

        public void Insert(EmpleadoEntity reg)
        {
            reg.FotoPerfil.PathOut = Data.Get("PathImg") + reg.Documento.TipoDocumento + reg.Documento.NumeroDocumento + ".jpeg";
            reg.FotoPerfil.TransferImage();

            using (SqlCommand cmd = new SqlCommand(InsertString, DataBase.Connection))
            {
                cmd.Parameters.AddWithValue("@nombres", reg.Nombres);
                cmd.Parameters.AddWithValue("@apellidos", reg.Apellidos);
                cmd.Parameters.AddWithValue("@cargo", reg.Cargo);
                cmd.Parameters.AddWithValue("@salario", reg.Salario);
                cmd.Parameters.AddWithValue("@foto_perfil", reg.FotoPerfil.PathOut);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", reg.FechaNacimiento);
                cmd.Parameters.AddWithValue("@fecha_ingreso", reg.FechaIngreso);
                cmd.Parameters.AddWithValue("@tipo_documento", reg.Documento.TipoDocumento);
                cmd.Parameters.AddWithValue("@Numero_documento", reg.Documento.NumeroDocumento);

                cmd.ExecuteNonQuery();
            }
        }

        private const string SelectString =
            "SELECT " +
            "nombres, apellidos, cargo, salario, foto_perfil, fecha_nacimiento, fecha_ingreso, fecha_retiro " +
            "FROM empleados WHERE tipo_documento=@tipo_documento AND numero_documento=@numero_documento;";

        public EmpleadoEntity Select(EmpleadoEntity reg)
        {
            using (SqlCommand cmd = new SqlCommand(SelectString, DataBase.Connection))
            {
                cmd.Parameters.AddWithValue("@tipo_documento", reg.Documento.TipoDocumento);
                cmd.Parameters.AddWithValue("@numero_documento", reg.Documento.NumeroDocumento);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows) return null;

                    reader.Read();

                    EmpleadoBuilder builder = new EmpleadoBuilder();

                    EmpleadoEntity empleado = builder
                        .Cargo(reader.GetString(reader.GetOrdinal("cargo")))
                        .Salario(reader.GetInt32(reader.GetOrdinal("salario")))
                        .Nombres(reader.GetString(reader.GetOrdinal("nombres")))
                        .Apellidos(reader.GetString(reader.GetOrdinal("apellidos")))
                        .FechaIngreso(reader.GetDateTime(reader.GetOrdinal("fecha_ingreso")))
                        .FechaNacimiento(reader.GetDateTime(reader.GetOrdinal("fecha_nacimiento")))
                        .FotoPerfil(new Foto(
                            reader.GetString(reader.GetOrdinal("foto_perfil")) == null ?
                            string.Empty :
                            reader.GetString(reader.GetOrdinal("foto_perfil"))))
                        .Documento(new Documento
                            (reg.Documento.TipoDocumento,
                            reg.Documento.NumeroDocumento))
                        .Build();


                    return empleado;
                }
            }
        }

        private const string SelectAllString =
            "SELECT " +
            "nombres, apellidos, cargo, salario, foto_perfil, fecha_nacimiento, fecha_ingreso, fecha_retiro, tipo_documento, numero_documento " +
            "FROM empleados";

        public List<EmpleadoEntity> SelectAll()
        {
            List<EmpleadoEntity> list = new List<EmpleadoEntity>();

            using (SqlCommand cmd = new SqlCommand(SelectAllString, DataBase.Connection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        EmpleadoBuilder builder = new EmpleadoBuilder();

                        builder
                            .Cargo(reader.GetString(reader.GetOrdinal("cargo")))
                            .Salario(reader.GetInt32(reader.GetOrdinal("salario")))
                            .Nombres(reader.GetString(reader.GetOrdinal("nombres")))
                            .Apellidos(reader.GetString(reader.GetOrdinal("apellidos")))
                            .FechaIngreso(reader.GetDateTime(reader.GetOrdinal("fecha_ingreso")))
                            .FechaNacimiento(reader.GetDateTime(reader.GetOrdinal("fecha_nacimiento")))
                            .Documento(new Documento
                                (reader.GetString(reader.GetOrdinal("tipo_documento")),
                                reader.GetString(reader.GetOrdinal("Numero_documento"))));

                        if (!reader.IsDBNull(reader.GetOrdinal("fecha_retiro")))
                        {
                            builder.FechaRetiro(reader.GetDateTime(reader.GetOrdinal("fecha_retiro")));
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("foto_perfil")))
                        {
                            builder.FotoPerfil(new Foto
                            (reader.GetString
                                (reader.GetOrdinal("foto_perfil"))));
                        }

                        list.Add(builder.Build());
                    }
                }
            }

            return list;
        }

        private const string UpdateString =
            "UPDATE empleados SET " +
            "nombres=@nombres, apellidos=@apellidos, cargo=@cargo, salario=@salario, fecha_retiro=@fecha_retiro " +
            "WHERE tipo_documento=@tipo_documento AND Numero_documento=@Numero_documento;";

        public void Update(EmpleadoEntity reg)
        {
            if (reg.FotoPerfil.PathOut != reg.FotoPerfil.PathIn)
            {
                reg.FotoPerfil.PathOut = Data.Get("PathImg") + reg.Documento.TipoDocumento + reg.Documento.NumeroDocumento + ".jpeg";
                reg.FotoPerfil.TransferImage();
            }

            using (SqlCommand cmd = new SqlCommand(UpdateString, DataBase.Connection))
            {
                cmd.Parameters.AddWithValue("@cargo", reg.Cargo);
                cmd.Parameters.AddWithValue("@salario", reg.Salario);
                cmd.Parameters.AddWithValue("@nombres", reg.Nombres);
                cmd.Parameters.AddWithValue("@apellidos", reg.Apellidos);
                cmd.Parameters.AddWithValue("@fecha_retiro", reg.FechaRetiro);
                cmd.Parameters.AddWithValue("@tipo_documento", reg.Documento.TipoDocumento);
                cmd.Parameters.AddWithValue("@Numero_documento", reg.Documento.NumeroDocumento);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
