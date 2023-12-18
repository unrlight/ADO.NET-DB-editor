using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kurichev_Lab3.CLASSES
{
    public class DataBase
    {

        private SqlConnection _connection = new SqlConnection(@"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public DataSet AllData { get; set; }
        public DataBase()
        {
            AllData = TableDataLoad();
        }

        public SqlConnection GetConnection()
        {
            return _connection;
        }

        public DataSet TableDataLoad()
        {
            var result = new DataSet();
            var stores = GetStore();
            var categorys = GetCategorys();
            result.Tables.Add(stores);
            result.Tables.Add(categorys);
            return result;
        }

        public DataTable GetCategorys()
        {
            _connection.Open();
            var command = new SqlCommand("SELECT * FROM usersdb.store.categoryTable", _connection);
            var adapter = new SqlDataAdapter(command);
            var result = new DataTable()
            {
                TableName = "Categorys",
            };
            adapter.Fill(result);
            _connection.Close();
            return result;
        }

        public DataTable GetStore()
        {
            _connection.Open();
            var query = "Select usersdb.store.storeTable.ID, usersdb.store.storeTable.Name," +
                "usersdb.store.categoryTable.CategoryName, usersdb.store.storeTable.Price, " +
                        "usersdb.store.storeTable.Rating, usersdb.store.storeTable.Avel " +
                        "From usersdb.store.storeTable " +
                        "Inner Join usersdb.store.categoryTable On " +
                        "usersdb.store.storeTable.CategoryID = usersdb.store.categoryTable.CategoryID";
            var command = new SqlCommand(query, _connection);
            var adapter = new SqlDataAdapter(command);
            var result = new DataTable()
            {
                TableName = "Store",
            };
            adapter.Fill(result);
            _connection.Close();
            return result;
        }

        public DataTable GetFilterCategorys(int id)
        {
            _connection.Open();
            var query = "Select usersdb.store.storeTable.ID, usersdb.store.storeTable.Name, " +
                "usersdb.store.categoryTable.CategoryName, usersdb.store.storeTable.Price, " +
                        "usersdb.store.storeTable.Rating, usersdb.store.storeTable.Avel " +
                        "From usersdb.store.storeTable " +
                        "Inner Join usersdb.store.categoryTable On usersdb.store.storeTable.CategoryID " +
                        "= usersdb.store.categoryTable.CategoryID " +
                        $"Where usersdb.store.storeTable.CategoryID = {id}";
            var command = new SqlCommand(query, _connection);
            var adapter = new SqlDataAdapter(command);
            var result = new DataTable()
            {
                TableName = "FilterCategorys",
            };
            adapter.Fill(result);
            _connection.Close();
            return result;
        }

        public DataTable GetCategoryIDbyName(string CategoryName)
        {
            _connection.Open();
            var query = $"select usersdb.store.categoryTable.CategoryID from usersdb.store.categoryTable where CategoryName='{CategoryName}'";
            var command = new SqlCommand(query, _connection);
            var adapter = new SqlDataAdapter(command);
            var result = new DataTable()
            {
                TableName = "CategoryID",
            };
            adapter.Fill(result);
            _connection.Close();
            return result;
        }

        public void EditQuery(int ID, string Name, int CategoryID, int Price, double Rating, bool Avel)
        {
            var AvelBit = Avel ? 1 : 0;
            _connection.Open();
            var query = $"UPDATE usersdb.store.storeTable SET Name='{Name}', CategoryID={CategoryID}, Price={Price}, Rating={Rating}, Avel={AvelBit} WHERE ID = {ID}";
            var command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();
            _connection.Close();

            _connection.Open();
            query = $"UPDATE usersdb.store.storeTable SET ID={ID} WHERE Name = '{Name}'";
            command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void AddQuery(int ID, string Name, int CategoryID, int Price, double Rating, bool Avel)
        {
            var AvelBit = Avel ? 1 : 0;
            _connection.Open();
            var query =
                $"Insert Into usersdb.store.storeTable (ID, Name, CategoryID, Price, Rating, Avel) " +
                $"Values ('{ID}', '{Name}', {CategoryID}, '{Price}', '{Rating}', {AvelBit})";
            var command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void AddCategoryQuery(string CategoryName, int CategoryID)
        {
            _connection.Open();
            var query =
                $"Insert Into usersdb.store.categoryTable (CategoryName, CategoryID) " +
                $"Values ('{CategoryName}', '{CategoryID}')";
            var command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void DeleteRow(int ID)
        {
            _connection.Open();
            var query = $"DELETE FROM usersdb.store.storeTable WHERE ID = {ID}";
            var command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void DeleteRowCategory(string Name)
        {
            _connection.Open();
            var query = $"DELETE FROM usersdb.store.categoryTable WHERE CategoryName = '{Name}'";
            var command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public DataTable GetFilterName(string Name)
        {
            _connection.Open();
            var query = $"Select ID, Name, usersdb.store.categoryTable.CategoryName, Price, Rating, Avel From store.storeTable Inner Join usersdb.store.categoryTable On usersdb.store.storeTable.CategoryID = usersdb.store.categoryTable.CategoryID Where usersdb.store.storeTable.Name LIKE '{Name}%'";
            var command = new SqlCommand(query, _connection);
            var adapter = new SqlDataAdapter(command);
            var result = new DataTable()
            {
                TableName = "FilterCategorys",
            };
            adapter.Fill(result);
            _connection.Close();
            return result;
        }

        public DataTable GetMinPrice()
        {
            _connection.Open();
            var query = "store.minprice";
            var command = new SqlCommand(query, _connection);
            var adapter = new SqlDataAdapter(command);
            var result = new DataTable()
            {
                TableName = "min_price",
            };
            adapter.Fill(result);
            _connection.Close();
            return result;
        }
    }
}
