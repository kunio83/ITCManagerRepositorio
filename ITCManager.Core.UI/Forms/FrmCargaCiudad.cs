﻿using ITCManager.Core.UI.Forms.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCManager.Core.UI.Forms
{
    public partial class FrmCargaCiudad : Base
    {
        public Calendar calendar;
        public String FechaCalendar { get; set; }

        public FrmCargaCiudad()
        {
            InitializeComponent();
        }

        private void ciudadSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ciudadSetBindingSource.EndEdit();
            this.rolCiudadEnProcesoSetBindingSource.EndEdit();
            this.rolCiudadActivaSetBindingSource.EndEdit();
            this.rolCiudadEnProcesoSetTableAdapter.Update(this.iTC_DBPOwerDataSet.RolCiudadEnProcesoSet);
            this.rolCiudadActivaSetTableAdapter.Update(this.iTC_DBPOwerDataSet.RolCiudadActivaSet);
            this.tableAdapterManager.UpdateAll(this.iTC_DBPOwerDataSet);

        }

        private void FrmCargaCiudad_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.RolCiudadActivaSet' table. You can move, or remove it, as needed.
            this.rolCiudadActivaSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.RolCiudadActivaSet);
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.RolCiudadEnProcesoSet' table. You can move, or remove it, as needed.
            this.rolCiudadEnProcesoSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.RolCiudadEnProcesoSet);
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.RolCiudadEnProcesoSet' table. You can move, or remove it, as needed.
            this.rolCiudadEnProcesoSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.RolCiudadEnProcesoSet);
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.LocalidadSet' table. You can move, or remove it, as needed.
            this.localidadSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.LocalidadSet);
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.LineaCiudadSet' table. You can move, or remove it, as needed.
            this.lineaCiudadSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.LineaCiudadSet);
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.CiudadSet' table. You can move, or remove it, as needed.
            this.ciudadSetTableAdapter.Fill(this.iTC_DBPOwerDataSet.CiudadSet);

            ciudadSetDataGridView.Sort(ciudadSetDataGridView.Columns["dataGridViewTextBoxColumn4"], ListSortDirection.Descending);
        }

        private string cargarArchivoEnServidor(string fileName)
        {
            try
            {
                String result = String.Empty;
                String pathDestino = Properties.Settings.Default.pathServerInformes;
                String fileNameDest = Path.GetFileName(fileName) + "_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                String extension = Path.GetExtension(fileName);
                if (Directory.Exists(pathDestino))
                {
                    File.Copy(fileName, pathDestino + fileNameDest + extension);
                    result = pathDestino + fileNameDest + extension;
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void ciudadSetDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
                FormRepository.CreateCellContMenuEditor(this.MdiParent, (DataGridView)sender, "Localidad", e.Location);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = null;
            String pathFileDest = String.Empty;
            //openFileDialog1.Filter = "Archivos de Texto (.txt)|*.txt|Archivos de Word  (*.doc,*.docx)|*.doc;*.docx|Archivos PDF(*.pdf)|*.pdf|Archivos de Excel (*.xls,*.xlsx)|*.xls;*.xlsx|Todos los Archivos (*.*)|*.*";
            openFileDialog1.Filter = "Todos los Archivos (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.CheckFileExists)
                {
                    pathFileDest = cargarArchivoEnServidor(openFileDialog1.FileName);
                    if (rolCiudadEnProcesoSetDataGridView.CurrentRow == null)
                        rolCiudadEnProcesoSetBindingSource.AddNew();

                    row = rolCiudadEnProcesoSetDataGridView.CurrentRow;
                    row.Cells["dataGridViewTextBoxColumn11"].Value = pathFileDest;
                }
            }
        }

        private void rolCiudadEnProcesoSetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == rolCiudadEnProcesoSetDataGridView.Rows[0].Cells["dataGridViewTextBoxColumn11"].ColumnIndex)
            {
                String pathArchivoAAbrir = rolCiudadEnProcesoSetDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                AbrirArchivo(pathArchivoAAbrir);
            }
        }

        private void AbrirArchivo(string pathArchivoAAbrir)
        {
            if (File.Exists(pathArchivoAAbrir))
                Process.Start(@pathArchivoAAbrir);
            else
                MessageBox.Show("Error!, el Archivo fue removido");
        }

        private void ciudadSetDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ciudadSetDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            
            if (Boolean.Parse(ciudadSetDataGridView.CurrentRow.Cells["Activa"].Value.ToString()))
                rolCiudadActivaSetDataGridView.Visible = true;
            else
                rolCiudadActivaSetDataGridView.Visible = false;
            Application.DoEvents();
        }

        private void ciudadSetDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Boolean.Parse(ciudadSetDataGridView.CurrentRow.Cells["Activa"].Value.ToString()))
                rolCiudadActivaSetDataGridView.Visible = true;
            else
                rolCiudadActivaSetDataGridView.Visible = false;
            Thread.Sleep(500);
        }

        private void rolCiudadActivaSetDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                if (calendar == null)
                    calendar = new Calendar(this);
                calendar.StartPosition = FormStartPosition.Manual;
                calendar.Location = Cursor.Position;
                calendar.ShowDialog();
                rolCiudadActivaSetDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.FechaCalendar;
            }
        }
    }
}