using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XRpg;

namespace XenoRPGEditor
{
	public partial class UserCtrlCharacterEditInfo: UserControl
	{
		public UserCtrlCharacterEditInfo()
		{
			InitializeComponent();
		}


		public UserCtrlCharacterEditInfo( uint iCharacterId )
		{
			InitializeComponent();

			//TODO: DO WE NEED THIS HERE?
			//CharacterManager.LoadAllStats(); // Attributes, resistances, skills


			// Init UI for item type selection...
			/*
			comboItemTypes.DataSource = new BindingSource( RpgMan.dictTypeNames, null );
			comboItemTypes.DisplayMember = "Value";
			comboItemTypes.ValueMember   = "Key";
			*/

			// Load default character
			var character = CharacterManager.LoadCharacterById( iCharacterId );
			PopulateCharInfo( character );

			// Load all stats...
			character.ListAllStats = CharacterManager.LoadCharacterStats( character.Id );
			textLevel.Text = $"{(int)character.CalculateCharacterLevel()}";

			// Must have DataTable in order to filter...
			DataTable dt = ToDataTable( character.ListAllStats );

			gridCharacterStats.DataSource = dt;
			AdjustGrid( gridCharacterStats );

		}


		//----------------------------------------------------------------------
		public static DataTable ToDataTable<T>( IList<T> data )
		{
			PropertyDescriptorCollection properties =
				TypeDescriptor.GetProperties(typeof(T));
			DataTable table = new DataTable();
			foreach (PropertyDescriptor prop in properties)
				table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
			foreach ( T item in data )
			{
				DataRow row = table.NewRow();
				foreach (PropertyDescriptor prop in properties)
				{
					row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
				}
				table.Rows.Add(row);
			}
			return table;
		}


		//----------------------------------------------------------------------
		private void PopulateCharInfo( CharacterBase character )
		{
			textNameFirst.Text = character.Name;
			textNameLast.Text  = character.NameLast;
			textAge.Text       = character.Age.ToString();
			textXpPool.Text    = character.XPPool.ToString();

			// Populate species and profession combo boxes
			var listSpecies = CharacterManager.GetSpeciesList();
			cbRace.DataSource    = listSpecies;
			cbRace.ValueMember   = "Id";
			cbRace.DisplayMember = "Name";

			var listProfs = CharacterManager.GetProfessionList();
			cbProfession.DataSource    = listProfs;
			cbProfession.ValueMember   = "Id";
			cbProfession.DisplayMember = "Name";

			// Populate stat type filter combo box...
			var listStatTypes = CharacterManager.GetStatTypeList();
			listStatTypes.Insert( 0, new StatType() { Id = 0, Name = "All" } );
			cbStatTypeFilter.DataSource    = listStatTypes;
			cbStatTypeFilter.ValueMember   = "Id";
			cbStatTypeFilter.DisplayMember = "Name";
		}


		//----------------------------------------------------------------------
		private void AdjustGrid( DataGridView dgv )
		{
			try
			{
				dgv.AllowUserToAddRows = false;
				dgv.AllowUserToDeleteRows = false;
				dgv.AllowUserToResizeRows = false;
				//dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

				// Set column properties...
				dgv.Columns[ "Id" ].Visible = false;

				dgv.Columns[ "TypeId" ].Visible = false;

				dgv.Columns[ "Name" ].ReadOnly = true;
				dgv.Columns[ "Name" ].DisplayIndex = 2;
				dgv.Columns[ "Name" ].Width = 150;

				dgv.Columns[ "Abbr" ].ReadOnly = true;
				dgv.Columns[ "Abbr" ].DisplayIndex = 3;
				dgv.Columns[ "Abbr" ].Width = 60;

				dgv.Columns[ "Level" ].DisplayIndex = 4;
				dgv.Columns[ "Level" ].Width = 50;

				dgv.Columns[ "XpToNextLvl" ].DisplayIndex = 5;

				dgv.Columns[ "TypeName" ].ReadOnly = true;
				//dgv.Columns[ "TypeName" ].DefaultCellStyle.BackColor = Color.FromArgb( 0xF0, 0xF0, 0xF0 );
				dgv.Columns[ "TypeName" ].HeaderText = "Type";
				dgv.Columns[ "TypeName" ].DisplayIndex = 6;
				dgv.Columns[ "TypeName" ].Width = 140;

				dgv.Columns[ "Description" ].ReadOnly = true;
				//dgv.Columns[ "Description" ].DefaultCellStyle.BackColor = Color.FromArgb( 0xFF, 0xF0, 0xF0 );
				dgv.Columns[ "Description" ].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


				//dgv.Columns[ 1 ].DefaultCellStyle.BackColor = colorPhysAttr;
				//dgv.Columns[ 2 ].DefaultCellStyle.BackColor = colorPhysAttr;
				//dgv.Columns[ 3 ].DefaultCellStyle.BackColor = colorPhysAttr;


				//dgv.Columns[ 0 ].HeaderText = "Name";
				//dgv.Columns[ 1 ].HeaderText = "Abbr";
				//dgv.Columns[ 2 ].HeaderText = "Desc";
				//dgv.Columns[ 3 ].HeaderText = "Lvl Base";
				//dgv.Columns[ 4 ].HeaderText = "Lvl Total";
				//dgv.Columns[ 5 ].HeaderText = "Score";
				//dgv.Columns[ 6 ].HeaderText = "XP";

				// Set column widths....
				//TODO: USE COLUMN NAMES
				//dgv.Columns[ 0 ].Width =  0; //TODO: REMOVE
				//dgv.Columns[ 1 ].Width = 90;
				//dgv.Columns[ 2 ].Width = 50;
				//dgv.Columns[ 3 ].Width = 40;
				//dgv.Columns[ 4 ].Width = 40;
				//dgv.Columns[ 5 ].Width = 40;
				//dgv.Columns[ 6 ].Width = 40;

				// Set read-only column colors
				Color colorPhysAttr = Color.FromArgb( 0xFF, 0xD0, 0xD0 );
				Color colorMentAttr = Color.FromArgb( 0xFF, 0xD0, 0xFF );
				Color colorSpecAttr = Color.FromArgb( 0xD0, 0xD0, 0xFF );
				Color colorResists  = Color.FromArgb( 0xD0, 0xFF, 0xD0 );
				Color colorSkills   = Color.FromArgb( 0xFF, 0xF0, 0xD0 );
				Color colorInvalid  = Color.FromArgb( 0xA0, 0xA0, 0xA0 );

				//TODO: Set description tooltips...
			}
			catch
			{
				; //IGNORE
			}
		}


		//----------------------------------------------------------------------
		// comboStatTypeFilter_SelectedIndexChanged()
		// • Filter stat list based on selected filter
		//----------------------------------------------------------------------
		private void comboStatTypeFilter_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( gridCharacterStats.DataSource == null ) return;

			var dt = (gridCharacterStats.DataSource as DataTable);
			// If "All" is selected, clear the filter...
			if ( cbStatTypeFilter.SelectedIndex == 0 )
			{
				dt.DefaultView.RowFilter = "";
			}
			else
			{
				dt.DefaultView.RowFilter = $"TypeId='{cbStatTypeFilter.SelectedIndex}'";
			}
		}

		private void gridCharacterStats_MouseEnter( object sender, EventArgs e )
		{
			gridCharacterStats.Focus();
		}

		private void gridCharacterStats_MouseLeave( object sender, EventArgs e )
		{
			panel3.Focus();
		}
	}
}
