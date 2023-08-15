using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Task1.Model
{
    public class Model
    {
        private SqlConnection _connection;

        public Model(string connectionString)
        {
            CreateConnection(connectionString);
        }

        public void ExecuteRequest(string commandStr)
        {
            try
            {
                OpenConnection();
                ExecuteCommand(commandStr);
                CloseConnection();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка при выполнении произовльного запроса: " + exception);
            }
        }
        public DataTable GetTable(string commandStr)
        {
            try
            {
                OpenConnection();

                var createCommand = ExecuteCommand(commandStr);
                if (createCommand == null) return null;

                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable(GetTableName(commandStr));
                dataAdp.Fill(dt);

                CloseConnection();
                return dt;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка при получении таблицы: " + exception);
                return new DataTable();
            }
        }

        private string GetTableName(string inputString) => inputString.Split(' ').Last();

        private SqlCommand ExecuteCommand(string commandStr)
        {
            try
            {
                var sqlCommand = new SqlCommand(commandStr, _connection);
                sqlCommand.ExecuteNonQuery();
                return sqlCommand;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка при выполнении SQL команды: "+exception);
                return null;
            }
        }

        private void CreateConnection(string connectionString)
        {
            try
            {
                _connection = new SqlConnection(connectionString);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка при создании подключения: " + exception);
            }
        }

        private void OpenConnection()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed) _connection.Open();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка при подключении: " + exception);
            }
        }

        private void CloseConnection()
        {
            try
            {
                if (_connection.State == ConnectionState.Open) _connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка при закрытии подключения: " + exception);
            }
        }
    }
}