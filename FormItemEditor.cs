using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace KevInvTest
{
	public partial class FormItemEditor: Form
	{
		public FormItemEditor()
		{
			InitializeComponent();


		}

		
		private void buttAddNewItem_Click( object sender, EventArgs e )
		{
			FormAddNewItem formAdd = new FormAddNewItem();
			formAdd.ShowDialog();
		}

		
		private void buttLoadTable_Click( object sender, EventArgs e )
		{
			string strDBConn = @"Data Source=InvTest.sqlite";
			SQLiteConnection sqlConn = 
				new SQLiteConnection( strDBConn );
			sqlConn.Open();

			// Execute query on database
			string strSQL = "SELECT * FROM " + comboTables.Text;

			SQLiteCommand sqlCmd = new SQLiteCommand( strSQL, sqlConn );
			SQLiteDataAdapter sqlAdapter = new SQLiteDataAdapter( sqlCmd );
			DataSet dataset = new DataSet();
			try
			{
				sqlAdapter.Fill( dataset );
				DataTable datatable = dataset.Tables[ 0 ];
				dataGridView1.DataSource = datatable;
			}
			catch ( Exception ex )
			{
				MessageBox.Show( "Error: " + ex.Message );
			}

			sqlConn.Close();

			dataGridView1.Columns[ 0 ].Width = 50; // ID
			dataGridView1.Columns[ 2 ].Width = 70; // ItemType
			dataGridView1.Columns[ 3 ].Width = 60; // Wt
			dataGridView1.Columns[ 4 ].Width = 50; // SizeW
			dataGridView1.Columns[ 5 ].Width = 50; // SizeH
			dataGridView1.Columns[ 6 ].Width = 60; // Qty
			dataGridView1.Columns[ 7 ].Width = 80; // QtyCap

			dataGridView1.Columns[ 2 ].HeaderText = "Type";
			dataGridView1.Columns[ 3 ].HeaderText = "Wt";
			dataGridView1.Columns[ 6 ].HeaderText = "Qty";
			dataGridView1.Columns[ 7 ].HeaderText = "Qty Cap";
		}
	}
}
