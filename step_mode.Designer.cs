
namespace CW_SMO
{
    partial class step_mode
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.finishButton = new System.Windows.Forms.Button();
            this.nextStepButton = new System.Windows.Forms.Button();
            this.devicesTable = new System.Windows.Forms.DataGridView();
            this.id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bufferTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countDevicesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.requestLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicesTable)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bufferTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.finishButton);
            this.groupBox5.Controls.Add(this.nextStepButton);
            this.groupBox5.Location = new System.Drawing.Point(1019, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(101, 519);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            // 
            // finishButton
            // 
            this.finishButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.finishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finishButton.Location = new System.Drawing.Point(-2, 168);
            this.finishButton.MaximumSize = new System.Drawing.Size(104, 37);
            this.finishButton.MinimumSize = new System.Drawing.Size(104, 37);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(104, 37);
            this.finishButton.TabIndex = 1;
            this.finishButton.Text = "Финиш";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // nextStepButton
            // 
            this.nextStepButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nextStepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextStepButton.Location = new System.Drawing.Point(-2, 108);
            this.nextStepButton.MaximumSize = new System.Drawing.Size(104, 37);
            this.nextStepButton.MinimumSize = new System.Drawing.Size(104, 37);
            this.nextStepButton.Name = "nextStepButton";
            this.nextStepButton.Size = new System.Drawing.Size(104, 37);
            this.nextStepButton.TabIndex = 0;
            this.nextStepButton.Text = "Шаг";
            this.nextStepButton.UseVisualStyleBackColor = true;
            this.nextStepButton.Click += new System.EventHandler(this.nextStepButton_Click);
            // 
            // devicesTable
            // 
            this.devicesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devicesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.devicesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.devicesTable.ColumnHeadersHeight = 30;
            this.devicesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id2,
            this.request2,
            this.ptr});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.devicesTable.DefaultCellStyle = dataGridViewCellStyle10;
            this.devicesTable.Location = new System.Drawing.Point(6, 88);
            this.devicesTable.Name = "devicesTable";
            this.devicesTable.RowHeadersWidth = 51;
            this.devicesTable.RowTemplate.Height = 24;
            this.devicesTable.Size = new System.Drawing.Size(410, 430);
            this.devicesTable.TabIndex = 16;
            // 
            // id2
            // 
            this.id2.FillWeight = 30F;
            this.id2.HeaderText = "id";
            this.id2.MinimumWidth = 6;
            this.id2.Name = "id2";
            // 
            // request2
            // 
            this.request2.HeaderText = "заявка";
            this.request2.MinimumWidth = 6;
            this.request2.Name = "request2";
            // 
            // ptr
            // 
            this.ptr.HeaderText = "указатель";
            this.ptr.MinimumWidth = 6;
            this.ptr.Name = "ptr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Кассы";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.devicesTable);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(595, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(418, 519);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // bufferTable
            // 
            this.bufferTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bufferTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bufferTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.bufferTable.ColumnHeadersHeight = 30;
            this.bufferTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.request,
            this.order,
            this.pack});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bufferTable.DefaultCellStyle = dataGridViewCellStyle12;
            this.bufferTable.Location = new System.Drawing.Point(6, 88);
            this.bufferTable.Name = "bufferTable";
            this.bufferTable.RowHeadersWidth = 51;
            this.bufferTable.RowTemplate.Height = 24;
            this.bufferTable.Size = new System.Drawing.Size(406, 431);
            this.bufferTable.TabIndex = 15;
            // 
            // id
            // 
            this.id.FillWeight = 30F;
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // request
            // 
            this.request.HeaderText = "заявка";
            this.request.MinimumWidth = 6;
            this.request.Name = "request";
            // 
            // order
            // 
            this.order.HeaderText = "порядок";
            this.order.MinimumWidth = 6;
            this.order.Name = "order";
            // 
            // pack
            // 
            this.pack.HeaderText = "в пакете";
            this.pack.MinimumWidth = 6;
            this.pack.Name = "pack";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Буфер";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.96179F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.8091F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.80935F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.419774F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1123, 525);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.countDevicesLabel);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(162, 519);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Источники";
            // 
            // countDevicesLabel
            // 
            this.countDevicesLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.countDevicesLabel.AutoSize = true;
            this.countDevicesLabel.BackColor = System.Drawing.SystemColors.Info;
            this.countDevicesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.countDevicesLabel.Location = new System.Drawing.Point(63, 292);
            this.countDevicesLabel.Name = "countDevicesLabel";
            this.countDevicesLabel.Size = new System.Drawing.Size(40, 25);
            this.countDevicesLabel.TabIndex = 9;
            this.countDevicesLabel.Text = "ИN";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(63, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "И1";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(63, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = " ... ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.requestLabel);
            this.groupBox1.Controls.Add(this.bufferTable);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(171, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 519);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // requestLabel
            // 
            this.requestLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.requestLabel.AutoSize = true;
            this.requestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.requestLabel.Location = new System.Drawing.Point(344, 34);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(37, 29);
            this.requestLabel.TabIndex = 17;
            this.requestLabel.Text = "---";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(232, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Заявка:";
            // 
            // step_mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1142, 549);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "step_mode";
            this.Text = "step_mode";
            this.Load += new System.EventHandler(this.step_mode_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.devicesTable)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bufferTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countDevicesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView bufferTable;
        private System.Windows.Forms.DataGridView devicesTable;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button nextStepButton;
        private System.Windows.Forms.Label requestLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn request2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptr;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn request;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn pack;
    }
}