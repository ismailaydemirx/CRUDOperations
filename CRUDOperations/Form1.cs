using System.Data;
using System.Data.SqlClient;

namespace CRUDOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=BAYDEMIRPC\SQLEXPRESS;Initial Catalog=school;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
            displaydata();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string query = $"insert into teacher values('{tbxTeacherId.Text.ToString()}','{tbxName.Text}','{tbxSurname.Text}','{tbxAddress.Text}','{tbxSalary.Text.ToString()}')";
            cmd.CommandText = query; // yukarıdaki sorgu dizesini komut nesnesinin CommandText 'e eşitler.
            conn.Open(); // veritabanı bağlantısını açtık
            cmd.ExecuteNonQuery(); // soryugu çalıştırdık ve yeni satırı tabloya ekledik.
            cleardata(); // aşağıdaki fonksiyonumuzu çağırarak insert yaptıktan sonra textbox'larda bulunanları sildik.
            conn.Close(); // veritabanı bağlantısını kapattık.
            displaydata();

        }

        private void cleardata()
        {
            // bu kod metin kutularında bulunan verileri temizleyecek.
            tbxTeacherId.Clear();
            tbxName.Clear();
            tbxSurname.Clear();
            tbxAddress.Clear();
            tbxSalary.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE teacher SET name='" + tbxName.Text + "', surname='" + tbxSurname.Text + "', address='" + tbxAddress.Text + "', salary='" + tbxSalary.Text.ToString() + "' WHERE id='" + tbxTeacherId.Text.ToString() + "' ";
            cmd.ExecuteNonQuery();
            conn.Close();
            displaydata();
            cleardata();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void displaydata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from teacher";
            cmd.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            dgwDatabase.DataSource = dataTable;
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = $"delete teacher where id='{tbxTeacherId.Text.ToString()}'";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            dgwDatabase.DataSource = query;
            conn.Close();
            displaydata();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from teacher where id={tbxTeacherId.Text}";
            cmd.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            tbxName.Text = dataTable.ToString();
            tbxSurname.Text = dataTable.ToString();
            tbxAddress.Text = dataTable.ToString();
            tbxSalary.Text = dataTable.ToString();
            dgwDatabase.DataSource = dataTable;
            conn.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}