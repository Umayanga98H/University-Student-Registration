
namespace Tutorial2
{
    partial class Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSstudent1 = new Tutorial2.DSstudent();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSstudent1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuIDDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.majorDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Student";
            this.dataGridView1.DataSource = this.dSstudent1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(668, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // stuIDDataGridViewTextBoxColumn
            // 
            this.stuIDDataGridViewTextBoxColumn.DataPropertyName = "StuID";
            this.stuIDDataGridViewTextBoxColumn.HeaderText = "StuID";
            this.stuIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stuIDDataGridViewTextBoxColumn.Name = "stuIDDataGridViewTextBoxColumn";
            this.stuIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "Lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Lname";
            this.lnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            this.lnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "Major";
            this.majorDataGridViewTextBoxColumn.HeaderText = "Major";
            this.majorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            this.majorDataGridViewTextBoxColumn.Width = 125;
            // 
            // dSstudent1
            // 
            this.dSstudent1.DataSetName = "DSstudent";
            this.dSstudent1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(60, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(229, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(394, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(571, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT Student.*\r\nFROM     Student";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-CK8BFUS;Initial Catalog=StudentReport_2017_199;Integrated Sec" +
    "urity=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [Student] ([StuID], [Fname], [Lname], [Major]) VALUES (@StuID, @Fname" +
    ", @Lname, @Major);\r\nSELECT StuID, Fname, Lname, Major FROM Student WHERE (StuID " +
    "= @StuID)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@StuID", System.Data.SqlDbType.Char, 0, "StuID"),
            new System.Data.SqlClient.SqlParameter("@Fname", System.Data.SqlDbType.VarChar, 0, "Fname"),
            new System.Data.SqlClient.SqlParameter("@Lname", System.Data.SqlDbType.VarChar, 0, "Lname"),
            new System.Data.SqlClient.SqlParameter("@Major", System.Data.SqlDbType.VarChar, 0, "Major")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@StuID", System.Data.SqlDbType.Char, 0, "StuID"),
            new System.Data.SqlClient.SqlParameter("@Fname", System.Data.SqlDbType.VarChar, 0, "Fname"),
            new System.Data.SqlClient.SqlParameter("@Lname", System.Data.SqlDbType.VarChar, 0, "Lname"),
            new System.Data.SqlClient.SqlParameter("@Major", System.Data.SqlDbType.VarChar, 0, "Major"),
            new System.Data.SqlClient.SqlParameter("@Original_StuID", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StuID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Lname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Major", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Major", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [Student] WHERE (([StuID] = @Original_StuID) AND ([Fname] = @Original" +
    "_Fname) AND ([Lname] = @Original_Lname) AND ([Major] = @Original_Major))";
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_StuID", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StuID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Lname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Major", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Major", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Student", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("StuID", "StuID"),
                        new System.Data.Common.DataColumnMapping("Fname", "Fname"),
                        new System.Data.Common.DataColumnMapping("Lname", "Lname"),
                        new System.Data.Common.DataColumnMapping("Major", "Major")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Details";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSstudent1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
        private DSstudent dSstudent1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}