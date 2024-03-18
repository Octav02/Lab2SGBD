using System.Configuration;
using System.Data;
using System.Xml;
using System.Data.SqlClient;

namespace Lab2
{
    public partial class Form1 : Form
    {
        
        SqlConnection _connection;
        SqlDataAdapter _parentDataAdapter;
        SqlDataAdapter _childDataAdapter;
        DataSet _dataSet;
        BindingSource _childBindingSource;
        BindingSource _parentBindingSource;
        private string? _parentTable;
        private string? _childTable;
        private string? _childFk;
        private string? _connectionString;

        private void loadDataFromXML()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("../../../date.xml");
            //Get resources connection string
            XmlNodeList xmlNodeList = xmlDocument.GetElementsByTagName("connectionString");
            _connectionString = xmlNodeList[0].InnerText;
            _parentTable = xmlDocument.GetElementsByTagName("parentTable")[0]!.InnerText;
            _childTable = xmlDocument.GetElementsByTagName("childTable")[0]!.InnerText;
            _childFk = xmlDocument.GetElementsByTagName("childFK")[0]!.InnerText;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDataFromXML();

            label1.Text = _parentTable;
            label2.Text = _childTable;

            string sqlQuery = "SELECT * FROM ";

            try
            {
                using (_connection = new SqlConnection(_connectionString))
                {
                    _connection.Open();
                    MessageBox.Show("Connection Open ! ");
                    _dataSet = new DataSet();

                    _parentDataAdapter = new SqlDataAdapter(sqlQuery + _parentTable, _connection);
                    _childDataAdapter = new SqlDataAdapter(sqlQuery + _childTable, _connection);

                    _parentDataAdapter.Fill(_dataSet, _parentTable ?? string.Empty);
                    _childDataAdapter.Fill(_dataSet, _childTable ?? string.Empty);

                    DataRelation dataRelation = new DataRelation("FK_" + _parentTable + "_" + _childTable,
                        _dataSet.Tables[_parentTable].Columns["id"],
                        _dataSet.Tables[_childTable].Columns[_childFk]);
                    _dataSet.Relations.Add(dataRelation);

                    _parentBindingSource = new BindingSource();
                    _childBindingSource = new BindingSource();
                    
                    _parentBindingSource.DataSource = _dataSet.Tables[_parentTable];
                    _childBindingSource.DataSource = _parentBindingSource;
                    _childBindingSource.DataMember = "FK_" + _parentTable + "_" + _childTable;

                    parentGridView.DataSource = _parentBindingSource;
                    childGridView.DataSource = _childBindingSource;
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                Console.WriteLine(ex.Message);
            }
        }  

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void parentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(_childDataAdapter);
            _childDataAdapter.Update(_dataSet, _childTable ?? string.Empty);
            SqlCommandBuilder sqlCommandBuilder2 = new SqlCommandBuilder(_parentDataAdapter);
            _parentDataAdapter.Update(_dataSet, _parentTable ?? string.Empty);
            
            
        }
    }
}
