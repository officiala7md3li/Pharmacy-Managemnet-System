﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Managemnet_System.GUI.Main_Menu___Helpers.Helping_Program
{
    public partial class SreachForm<T> : Form where T : ContainerControl, new()
    {
        public List<T> Items { get; set; }
        public SreachForm(List<T> items)
        {
            InitializeComponent();
            Items=items;
            // Create the DataGridViewButtonColumn for the first column.
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = "ButtonColumn",
                HeaderText = "التفاصيل",
                Text = "عرض",
                DisplayIndex = 0,
                Width = 79,
                SortMode = DataGridViewColumnSortMode.Programmatic,
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                FlatStyle = FlatStyle.Flat,
            };

            // Add the button column to the DataGridView.
            DGV_Search.Columns.Add(buttonColumn);

            // Bind the generic list to the DataGridView.
            DGV_Search.DataSource = Items;

            // Enable column header editing.
            DGV_Search.EnableHeadersVisualStyles = false;
            DGV_Search.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            DGV_Search.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            DGV_Search.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            DGV_Search.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            DGV_Search.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            DGV_Search.DefaultCellStyle.Font = new Font("Cairo", 8.0f);
            DGV_Search.DefaultCellStyle.ForeColor = Color.White;
            DGV_Search.DefaultCellStyle.SelectionBackColor = Color.FromArgb(2, 188, 152);
            DGV_Search.DefaultCellStyle.SelectionForeColor = Color.White;
            DGV_Search.DefaultCellStyle.BackColor = Color.FromArgb(2, 188, 152);
            DGV_Search.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Search.DefaultCellStyle.Font = new Font("Cairo", 8.0f);
            //DGV_Search.CellTemplate.Style.BackColor = Color.FromArgb(2, 188, 152);
            //DGV_Search.CellTemplate.Style.ForeColor = Color.White;
            //DGV_Search.CellTemplate.Style.SelectionBackColor = Color.FromArgb(170, 199, 254);

            // Hook up the event handler for column header editing.
            DGV_Search.ColumnHeaderMouseDoubleClick += DGV_Search_ColumnHeaderMouseDoubleClick;
        }
        public SreachForm()
        {
            InitializeComponent();
        }
        private void DGV_Search_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Allow editing of the column header text.
            if (e.ColumnIndex >= 1) // Skip the first column (Button Column).
            {
                DGV_Search.BeginEdit(false);
            }
        }
    }
}
