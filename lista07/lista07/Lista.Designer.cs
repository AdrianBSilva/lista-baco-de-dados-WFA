namespace lista07
{
    partial class Lista
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNota01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNota02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnnNota03 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFrequnecia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNome,
            this.ColumnNota01,
            this.ColumnNota02,
            this.ColumnnNota03,
            this.ColumnFrequnecia});
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 420);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Visible = false;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            // 
            // ColumnNota01
            // 
            this.ColumnNota01.HeaderText = "Nota 01";
            this.ColumnNota01.Name = "ColumnNota01";
            // 
            // ColumnNota02
            // 
            this.ColumnNota02.HeaderText = "Nota 02";
            this.ColumnNota02.Name = "ColumnNota02";
            // 
            // ColumnnNota03
            // 
            this.ColumnnNota03.HeaderText = "Nota 03";
            this.ColumnnNota03.Name = "ColumnnNota03";
            // 
            // ColumnFrequnecia
            // 
            this.ColumnFrequnecia.HeaderText = "Frequência";
            this.ColumnFrequnecia.Name = "ColumnFrequnecia";
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 472);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lista";
            this.Text = "Lista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNota01;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNota02;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnnNota03;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFrequnecia;
    }
}