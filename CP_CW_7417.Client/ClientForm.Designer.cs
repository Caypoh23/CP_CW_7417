namespace CP_CW_7417.Client
{
    partial class SwipesCollectionManagementForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvTerminals = new System.Windows.Forms.DataGridView();
            this.dgvDatabase = new System.Windows.Forms.DataGridView();
            this.lblTerminals = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 327);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(307, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // dgvTerminals
            // 
            this.dgvTerminals.AllowUserToAddRows = false;
            this.dgvTerminals.AllowUserToDeleteRows = false;
            this.dgvTerminals.AllowUserToResizeColumns = false;
            this.dgvTerminals.AllowUserToResizeRows = false;
            this.dgvTerminals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTerminals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTerminals.Location = new System.Drawing.Point(12, 55);
            this.dgvTerminals.Name = "dgvTerminals";
            this.dgvTerminals.ReadOnly = true;
            this.dgvTerminals.Size = new System.Drawing.Size(307, 256);
            this.dgvTerminals.TabIndex = 4;
            this.dgvTerminals.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTerminals_CellFormatting);
            // 
            // dgvDatabase
            // 
            this.dgvDatabase.AllowUserToAddRows = false;
            this.dgvDatabase.AllowUserToDeleteRows = false;
            this.dgvDatabase.AllowUserToResizeColumns = false;
            this.dgvDatabase.AllowUserToResizeRows = false;
            this.dgvDatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabase.Location = new System.Drawing.Point(342, 55);
            this.dgvDatabase.Name = "dgvDatabase";
            this.dgvDatabase.ReadOnly = true;
            this.dgvDatabase.Size = new System.Drawing.Size(493, 256);
            this.dgvDatabase.TabIndex = 5;
            // 
            // lblTerminals
            // 
            this.lblTerminals.AutoSize = true;
            this.lblTerminals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTerminals.Location = new System.Drawing.Point(119, 16);
            this.lblTerminals.Name = "lblTerminals";
            this.lblTerminals.Size = new System.Drawing.Size(107, 26);
            this.lblTerminals.TabIndex = 6;
            this.lblTerminals.Text = "Terminals";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDatabase.Location = new System.Drawing.Point(550, 16);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(105, 26);
            this.lblDatabase.TabIndex = 6;
            this.lblDatabase.Text = "Database";
            // 
            // SwipesCollectionManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 398);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.lblTerminals);
            this.Controls.Add(this.dgvDatabase);
            this.Controls.Add(this.dgvTerminals);
            this.Controls.Add(this.btnStart);
            this.Name = "SwipesCollectionManagementForm";
            this.Text = "Swipes Collection Management";
            this.Load += new System.EventHandler(this.SwipesCollectionManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvTerminals;
        private System.Windows.Forms.DataGridView dgvDatabase;
        private System.Windows.Forms.Label lblTerminals;
        private System.Windows.Forms.Label lblDatabase;
    }
}

