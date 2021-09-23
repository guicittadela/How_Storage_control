
namespace How
{
    partial class dbEstoque
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dbEstoque));
            this.dgStorage = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbRef = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTamanho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQtd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.tbRetirar = new System.Windows.Forms.TextBox();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdcionar = new System.Windows.Forms.Button();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAtivo = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgStorage
            // 
            this.dgStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnNome,
            this.columnRef,
            this.columnQtd,
            this.columnCor,
            this.columnTamanho,
            this.ColumnAtivo,
            this.columnEditar});
            this.dgStorage.Location = new System.Drawing.Point(10, 315);
            this.dgStorage.Name = "dgStorage";
            this.dgStorage.Size = new System.Drawing.Size(912, 245);
            this.dgStorage.TabIndex = 0;
            this.dgStorage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStorage_CellContentClick);
            this.dgStorage.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgStorage_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Produto";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tbName.Location = new System.Drawing.Point(149, 92);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(179, 23);
            this.tbName.TabIndex = 2;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tbRef
            // 
            this.tbRef.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tbRef.Location = new System.Drawing.Point(149, 121);
            this.tbRef.Name = "tbRef";
            this.tbRef.Size = new System.Drawing.Size(100, 23);
            this.tbRef.TabIndex = 4;
            this.tbRef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRef_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Referência";
            // 
            // tbTamanho
            // 
            this.tbTamanho.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tbTamanho.Location = new System.Drawing.Point(149, 211);
            this.tbTamanho.Name = "tbTamanho";
            this.tbTamanho.Size = new System.Drawing.Size(100, 23);
            this.tbTamanho.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tamanho";
            // 
            // tbQtd
            // 
            this.tbQtd.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tbQtd.Location = new System.Drawing.Point(149, 151);
            this.tbQtd.Name = "tbQtd";
            this.tbQtd.Size = new System.Drawing.Size(100, 23);
            this.tbQtd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade";
            // 
            // tbCor
            // 
            this.tbCor.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tbCor.Location = new System.Drawing.Point(149, 180);
            this.tbCor.Name = "tbCor";
            this.tbCor.Size = new System.Drawing.Size(100, 23);
            this.tbCor.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cor";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tbId.Location = new System.Drawing.Point(149, 240);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(42, 23);
            this.tbId.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(10, 277);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 13;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(172, 277);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // tbRetirar
            // 
            this.tbRetirar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tbRetirar.Location = new System.Drawing.Point(727, 248);
            this.tbRetirar.Name = "tbRetirar";
            this.tbRetirar.Size = new System.Drawing.Size(157, 23);
            this.tbRetirar.TabIndex = 17;
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(727, 277);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(75, 23);
            this.btnRetirar.TabIndex = 18;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(253, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Apagar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::How.Properties.Resources.Ativo_1;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Editar";
            this.dataGridViewImageColumn2.Image = global::How.Properties.Resources.Ativo_1;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 16;
            // 
            // btnAdcionar
            // 
            this.btnAdcionar.Location = new System.Drawing.Point(809, 277);
            this.btnAdcionar.Name = "btnAdcionar";
            this.btnAdcionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdcionar.TabIndex = 22;
            this.btnAdcionar.Text = "Adicionar";
            this.btnAdcionar.UseVisualStyleBackColor = true;
            this.btnAdcionar.Click += new System.EventHandler(this.btnAdcionar_Click);
            // 
            // columnId
            // 
            this.columnId.HeaderText = "ID";
            this.columnId.Name = "columnId";
            this.columnId.Width = 50;
            // 
            // columnNome
            // 
            this.columnNome.HeaderText = "Nome do Produto";
            this.columnNome.Name = "columnNome";
            this.columnNome.Width = 375;
            // 
            // columnRef
            // 
            this.columnRef.HeaderText = "ref";
            this.columnRef.Name = "columnRef";
            this.columnRef.Width = 50;
            // 
            // columnQtd
            // 
            this.columnQtd.HeaderText = "Quantidade";
            this.columnQtd.Name = "columnQtd";
            // 
            // columnCor
            // 
            this.columnCor.HeaderText = "Cor";
            this.columnCor.Name = "columnCor";
            // 
            // columnTamanho
            // 
            this.columnTamanho.HeaderText = "Tamanho";
            this.columnTamanho.Name = "columnTamanho";
            // 
            // ColumnAtivo
            // 
            this.ColumnAtivo.HeaderText = "Ativo";
            this.ColumnAtivo.Image = global::How.Properties.Resources.Ativo_11;
            this.ColumnAtivo.Name = "ColumnAtivo";
            this.ColumnAtivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnAtivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnAtivo.Width = 75;
            // 
            // columnEditar
            // 
            this.columnEditar.HeaderText = "";
            this.columnEditar.Image = global::How.Properties.Resources.Ativo_1;
            this.columnEditar.Name = "columnEditar";
            this.columnEditar.Width = 18;
            // 
            // dbEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 563);
            this.Controls.Add(this.btnAdcionar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.tbRetirar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbQtd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTamanho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRef);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgStorage);
            this.Name = "dbEstoque";
            this.Text = "Controle de Estoque";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStorage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgStorage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbRef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTamanho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQtd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox tbRetirar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdcionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTamanho;
        private System.Windows.Forms.DataGridViewImageColumn ColumnAtivo;
        private System.Windows.Forms.DataGridViewImageColumn columnEditar;
    }
}

