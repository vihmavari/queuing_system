
namespace CW_SMO
{
    partial class finish
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
            this.statTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probability_of_refuse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avg_time_in_system = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avg_time_in_buffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avg_time_on_device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispersion_buffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispersion_device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statTable2 = new System.Windows.Forms.DataGridView();
            this.id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usage_of_device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.statTable)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statTable2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statTable
            // 
            this.statTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.requests,
            this.probability_of_refuse,
            this.avg_time_in_system,
            this.avg_time_in_buffer,
            this.avg_time_on_device,
            this.dispersion_buffer,
            this.dispersion_device});
            this.statTable.Location = new System.Drawing.Point(13, 12);
            this.statTable.Name = "statTable";
            this.statTable.RowHeadersWidth = 51;
            this.statTable.RowTemplate.Height = 24;
            this.statTable.Size = new System.Drawing.Size(738, 379);
            this.statTable.TabIndex = 0;
            // 
            // id
            // 
            this.id.FillWeight = 30F;
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // requests
            // 
            this.requests.HeaderText = "Кол-во заявок";
            this.requests.MinimumWidth = 6;
            this.requests.Name = "requests";
            // 
            // probability_of_refuse
            // 
            this.probability_of_refuse.HeaderText = "Вероятность отказа";
            this.probability_of_refuse.MinimumWidth = 6;
            this.probability_of_refuse.Name = "probability_of_refuse";
            // 
            // avg_time_in_system
            // 
            this.avg_time_in_system.HeaderText = "Ср. время заявок в системе";
            this.avg_time_in_system.MinimumWidth = 6;
            this.avg_time_in_system.Name = "avg_time_in_system";
            // 
            // avg_time_in_buffer
            // 
            this.avg_time_in_buffer.HeaderText = "Ср. время в буфере";
            this.avg_time_in_buffer.MinimumWidth = 6;
            this.avg_time_in_buffer.Name = "avg_time_in_buffer";
            // 
            // avg_time_on_device
            // 
            this.avg_time_on_device.HeaderText = "Ср. время обработки";
            this.avg_time_on_device.MinimumWidth = 6;
            this.avg_time_on_device.Name = "avg_time_on_device";
            // 
            // dispersion_buffer
            // 
            this.dispersion_buffer.HeaderText = "Дисперсия времени в буфере";
            this.dispersion_buffer.MinimumWidth = 6;
            this.dispersion_buffer.Name = "dispersion_buffer";
            // 
            // dispersion_device
            // 
            this.dispersion_device.HeaderText = "Дисперсия времени обработки";
            this.dispersion_device.MinimumWidth = 6;
            this.dispersion_device.Name = "dispersion_device";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 426);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.statTable2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "devices";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statTable2
            // 
            this.statTable2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statTable2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statTable2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statTable2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id2,
            this.usage_of_device});
            this.statTable2.Location = new System.Drawing.Point(15, 9);
            this.statTable2.Name = "statTable2";
            this.statTable2.RowHeadersWidth = 51;
            this.statTable2.RowTemplate.Height = 24;
            this.statTable2.Size = new System.Drawing.Size(738, 379);
            this.statTable2.TabIndex = 1;
            // 
            // id2
            // 
            this.id2.FillWeight = 30F;
            this.id2.HeaderText = "id";
            this.id2.MinimumWidth = 6;
            this.id2.Name = "id2";
            // 
            // usage_of_device
            // 
            this.usage_of_device.HeaderText = "Использование устройств";
            this.usage_of_device.MinimumWidth = 6;
            this.usage_of_device.Name = "usage_of_device";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "clients";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // finish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "finish";
            this.Text = "finish";
            this.Load += new System.EventHandler(this.finish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statTable)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statTable2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView statTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn requests;
        private System.Windows.Forms.DataGridViewTextBoxColumn probability_of_refuse;
        private System.Windows.Forms.DataGridViewTextBoxColumn avg_time_in_system;
        private System.Windows.Forms.DataGridViewTextBoxColumn avg_time_in_buffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn avg_time_on_device;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispersion_buffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispersion_device;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView statTable2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn usage_of_device;
        private System.Windows.Forms.TabPage tabPage1;
    }
}