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
			var _character = CharacterManager.LoadCharacterById( iCharacterId );
			PopulateCharInfo( _character );

			// Load stats...
			var listCharStats = CharacterManager.LoadCharacterStats( _character.Id );

			// Must have DataTable in order to filter...
			DataTable dt = ToDataTable( listCharStats );

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
			comboRace.DataSource    = listSpecies;
			comboRace.ValueMember   = "Id";
			comboRace.DisplayMember = "Name";

			var listProfs = CharacterManager.GetProfessionList();
			comboProfession.DataSource    = listProfs;
			comboProfession.ValueMember   = "Id";
			comboProfession.DisplayMember = "Name";

			// Populate stat type filter combo box...
			var listStatTypes = CharacterManager.GetStatTypeList();
			listStatTypes.Insert( 0, new StatType() { Id = 0, Name = "All" } );
			comboStatTypeFilter.DataSource    = listStatTypes;
			comboStatTypeFilter.ValueMember   = "Id";
			comboStatTypeFilter.DisplayMember = "Name";
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
				dgv.Columns[ "Name" ].DefaultCellStyle.BackColor = Color.FromArgb( 0xF0, 0xF0, 0xF0 );
				dgv.Columns[ "Name" ].DisplayIndex = 0;
				dgv.Columns[ "Name" ].Width = 120;

				dgv.Columns[ "Abbr" ].ReadOnly = true;
				dgv.Columns[ "Abbr" ].DefaultCellStyle.BackColor = Color.FromArgb( 0xF0, 0xF0, 0xF0 );
				dgv.Columns[ "Abbr" ].DisplayIndex = 1;
				dgv.Columns[ "Abbr" ].Width = 50;

				dgv.Columns[ "Level" ].DisplayIndex = 2;
				dgv.Columns[ "Level" ].Width = 50;

				dgv.Columns[ "XpToNextLvl" ].DisplayIndex = 3;

				dgv.Columns[ "TypeName" ].ReadOnly = true;
				dgv.Columns[ "TypeName" ].DefaultCellStyle.BackColor = Color.FromArgb( 0xF0, 0xF0, 0xF0 );
				dgv.Columns[ "TypeName" ].DisplayIndex = 4;

				dgv.Columns[ "Description" ].ReadOnly = true;
				dgv.Columns[ "Description" ].DefaultCellStyle.BackColor = Color.FromArgb( 0xF0, 0xF0, 0xF0 );
				dgv.Columns[ "Description" ].DisplayIndex = 5;


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

				//NOTE: THIS CODE DOESN'T SEEM TO WORK; NO CELL PROPERTIES EVER CHANGE
				// Set tooltips...
				foreach( DataGridViewRow row in dgv.Rows )
				{
					StatTypeEnum statType = (StatTypeEnum)Convert.ToInt32( row.Cells["TypeId"].Value.ToString() );
					switch ( statType )
					{
						case StatTypeEnum.AttribPhysical: row.Cells[0].ToolTipText = row.Cells["Description"].Value.ToString() ; break;
						case StatTypeEnum.AttribMental  : row.Cells[0].Style.ForeColor = colorMentAttr; break;
						case StatTypeEnum.AttribSpecial : row.Cells[0].Style.ForeColor = colorSpecAttr; break;
						case StatTypeEnum.Resistance    : row.Cells[0].Style.ForeColor = colorResists;  break;
						case StatTypeEnum.Skill         : row.Cells[0].Style.ForeColor = colorSkills;   break;
						case StatTypeEnum.Special       : row.Cells[0].Style.ForeColor = colorInvalid;  break;
						default                         : row.Cells[0].Style.ForeColor = colorInvalid;  break;
					}
				}
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
			if ( comboStatTypeFilter.SelectedIndex == 0 )
			{
				dt.DefaultView.RowFilter = "";
			}
			else
			{
				dt.DefaultView.RowFilter = $"TypeId='{comboStatTypeFilter.SelectedIndex}'";
			}
		}

	}
}
