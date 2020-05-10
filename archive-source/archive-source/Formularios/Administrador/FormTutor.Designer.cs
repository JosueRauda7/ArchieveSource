﻿namespace archive_source.Formularios.Administrador
{
    partial class FormTutor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTutor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnNuevoTutor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBuscar2 = new Bunifu.Framework.UI.BunifuTextbox();
            this.dgvTutores = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(128)))));
            this.panelForm.Controls.Add(this.btnNuevoTutor);
            this.panelForm.Controls.Add(this.txtBuscar2);
            this.panelForm.Controls.Add(this.dgvTutores);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1244, 545);
            this.panelForm.TabIndex = 5;
            // 
            // btnNuevoTutor
            // 
            this.btnNuevoTutor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevoTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevoTutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoTutor.BorderRadius = 0;
            this.btnNuevoTutor.ButtonText = "Nuevo Tutor";
            this.btnNuevoTutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoTutor.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevoTutor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevoTutor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevoTutor.Iconimage")));
            this.btnNuevoTutor.Iconimage_right = null;
            this.btnNuevoTutor.Iconimage_right_Selected = null;
            this.btnNuevoTutor.Iconimage_Selected = null;
            this.btnNuevoTutor.IconMarginLeft = 0;
            this.btnNuevoTutor.IconMarginRight = 0;
            this.btnNuevoTutor.IconRightVisible = true;
            this.btnNuevoTutor.IconRightZoom = 0D;
            this.btnNuevoTutor.IconVisible = true;
            this.btnNuevoTutor.IconZoom = 90D;
            this.btnNuevoTutor.IsTab = false;
            this.btnNuevoTutor.Location = new System.Drawing.Point(63, 128);
            this.btnNuevoTutor.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevoTutor.Name = "btnNuevoTutor";
            this.btnNuevoTutor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevoTutor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(128)))));
            this.btnNuevoTutor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevoTutor.selected = false;
            this.btnNuevoTutor.Size = new System.Drawing.Size(203, 59);
            this.btnNuevoTutor.TabIndex = 4;
            this.btnNuevoTutor.Text = "Nuevo Tutor";
            this.btnNuevoTutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoTutor.Textcolor = System.Drawing.Color.White;
            this.btnNuevoTutor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoTutor.Click += new System.EventHandler(this.btnNuevoTutor_Click);
            // 
            // txtBuscar2
            // 
            this.txtBuscar2.BackColor = System.Drawing.Color.Snow;
            this.txtBuscar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar2.BackgroundImage")));
            this.txtBuscar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txtBuscar2.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscar2.Icon")));
            this.txtBuscar2.Location = new System.Drawing.Point(612, 135);
            this.txtBuscar2.Margin = new System.Windows.Forms.Padding(5);
            this.txtBuscar2.Name = "txtBuscar2";
            this.txtBuscar2.Size = new System.Drawing.Size(333, 52);
            this.txtBuscar2.TabIndex = 3;
            this.txtBuscar2.text = "";
            this.txtBuscar2.OnTextChange += new System.EventHandler(this.txtBuscar_OnTextChange);
            // 
            // dgvTutores
            // 
            this.dgvTutores.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTutores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTutores.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvTutores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTutores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTutores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTutores.DoubleBuffered = true;
            this.dgvTutores.EnableHeadersVisualStyles = false;
            this.dgvTutores.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvTutores.HeaderForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTutores.Location = new System.Drawing.Point(63, 194);
            this.dgvTutores.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTutores.Name = "dgvTutores";
            this.dgvTutores.ReadOnly = true;
            this.dgvTutores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTutores.Size = new System.Drawing.Size(883, 310);
            this.dgvTutores.TabIndex = 2;
            this.dgvTutores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTutores_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "TUTORES";
            // 
            // FormTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 545);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTutor";
            this.Text = "FormTutor";
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevoTutor;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTutores;
    }
}