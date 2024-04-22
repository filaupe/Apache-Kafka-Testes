namespace Kafka.WinForms.Client
{
    partial class TableUpdater
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewHistoric = new DataGridView();
            historicDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kafkaMessageViewModelBindingSource = new BindingSource(components);
            textBoxLastMsg = new TextBox();
            label1 = new Label();
            backgroundWorkerConsumer = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistoric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kafkaMessageViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHistoric
            // 
            dataGridViewHistoric.AllowUserToAddRows = false;
            dataGridViewHistoric.AllowUserToDeleteRows = false;
            dataGridViewHistoric.AutoGenerateColumns = false;
            dataGridViewHistoric.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHistoric.BorderStyle = BorderStyle.None;
            dataGridViewHistoric.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistoric.Columns.AddRange(new DataGridViewColumn[] { historicDataGridViewTextBoxColumn });
            dataGridViewHistoric.DataSource = kafkaMessageViewModelBindingSource;
            dataGridViewHistoric.Dock = DockStyle.Bottom;
            dataGridViewHistoric.Location = new Point(0, 64);
            dataGridViewHistoric.Name = "dataGridViewHistoric";
            dataGridViewHistoric.ReadOnly = true;
            dataGridViewHistoric.RowHeadersVisible = false;
            dataGridViewHistoric.Size = new Size(248, 330);
            dataGridViewHistoric.TabIndex = 0;
            // 
            // historicDataGridViewTextBoxColumn
            // 
            historicDataGridViewTextBoxColumn.DataPropertyName = "Historic";
            historicDataGridViewTextBoxColumn.HeaderText = "Histórico";
            historicDataGridViewTextBoxColumn.Name = "historicDataGridViewTextBoxColumn";
            historicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kafkaMessageViewModelBindingSource
            // 
            kafkaMessageViewModelBindingSource.DataSource = typeof(Models.KafkaMessageViewModel);
            // 
            // textBoxLastMsg
            // 
            textBoxLastMsg.DataBindings.Add(new Binding("Text", kafkaMessageViewModelBindingSource, "Historic", true));
            textBoxLastMsg.DataBindings.Add(new Binding("DataContext", kafkaMessageViewModelBindingSource, "Historic", true));
            textBoxLastMsg.Location = new Point(11, 31);
            textBoxLastMsg.Name = "textBoxLastMsg";
            textBoxLastMsg.ReadOnly = true;
            textBoxLastMsg.Size = new Size(225, 23);
            textBoxLastMsg.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 19);
            label1.TabIndex = 2;
            label1.Text = "Última mensagem:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backgroundWorkerConsumer
            // 
            backgroundWorkerConsumer.WorkerReportsProgress = true;
            backgroundWorkerConsumer.WorkerSupportsCancellation = true;
            backgroundWorkerConsumer.DoWork += backgroundWorkerConsumer_DoWork;
            backgroundWorkerConsumer.ProgressChanged += backgroundWorkerConsumer_ProgressChanged;
            // 
            // TableUpdater
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(248, 394);
            Controls.Add(label1);
            Controls.Add(textBoxLastMsg);
            Controls.Add(dataGridViewHistoric);
            Name = "TableUpdater";
            Text = "Atualizar Tabela";
            Load += TableUpdater_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistoric).EndInit();
            ((System.ComponentModel.ISupportInitialize)kafkaMessageViewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewHistoric;
        private TextBox textBoxLastMsg;
        private Label label1;
        private DataGridViewTextBoxColumn historicDataGridViewTextBoxColumn;
        private BindingSource kafkaMessageViewModelBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorkerConsumer;
    }
}
