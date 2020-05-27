namespace TP_Guitar_Frabiquant
{
    partial class EditionEntreprise
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
            this.components = new System.ComponentModel.Container();
            this.ItemToShowCbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MontrerBtn = new System.Windows.Forms.Button();
            this.ItemsList = new System.Windows.Forms.ListBox();
            this.GridCommandes = new System.Windows.Forms.DataGridView();
            this.InputElement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VibratoCircle = new System.Windows.Forms.RadioButton();
            this.TypeBoisCircle = new System.Windows.Forms.RadioButton();
            this.MicroCircle = new System.Windows.Forms.RadioButton();
            this.EffacerEl = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.EffacerCommandeBtn = new System.Windows.Forms.Button();
            this.nroCommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomguitarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPos1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPos2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPos3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boisCorpsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boisToucheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boisMancheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBONCOMMANDEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridCommandes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBONCOMMANDEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemToShowCbx
            // 
            this.ItemToShowCbx.FormattingEnabled = true;
            this.ItemToShowCbx.Items.AddRange(new object[] {
            "Commandes",
            "Type de Vibrato",
            "Constructeur du Micro",
            "Type de Bois"});
            this.ItemToShowCbx.Location = new System.Drawing.Point(15, 32);
            this.ItemToShowCbx.Name = "ItemToShowCbx";
            this.ItemToShowCbx.Size = new System.Drawing.Size(149, 21);
            this.ItemToShowCbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produit a Montrer";
            // 
            // MontrerBtn
            // 
            this.MontrerBtn.Location = new System.Drawing.Point(15, 59);
            this.MontrerBtn.Name = "MontrerBtn";
            this.MontrerBtn.Size = new System.Drawing.Size(152, 42);
            this.MontrerBtn.TabIndex = 3;
            this.MontrerBtn.Text = "Montrer";
            this.MontrerBtn.UseVisualStyleBackColor = true;
            this.MontrerBtn.Click += new System.EventHandler(this.MontrerBtn_Click);
            // 
            // ItemsList
            // 
            this.ItemsList.FormattingEnabled = true;
            this.ItemsList.Location = new System.Drawing.Point(278, 12);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(669, 225);
            this.ItemsList.TabIndex = 4;
            // 
            // GridCommandes
            // 
            this.GridCommandes.AutoGenerateColumns = false;
            this.GridCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCommandes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroCommandeDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.nomguitarDataGridViewTextBoxColumn,
            this.mPos1DataGridViewTextBoxColumn,
            this.mPos2DataGridViewTextBoxColumn,
            this.mPos3DataGridViewTextBoxColumn,
            this.boisCorpsDataGridViewTextBoxColumn,
            this.boisToucheDataGridViewTextBoxColumn,
            this.boisMancheDataGridViewTextBoxColumn,
            this.dateCommandeDataGridViewTextBoxColumn,
            this.montantDataGridViewTextBoxColumn});
            this.GridCommandes.DataSource = this.cBONCOMMANDEBindingSource;
            this.GridCommandes.Location = new System.Drawing.Point(287, 252);
            this.GridCommandes.Name = "GridCommandes";
            this.GridCommandes.Size = new System.Drawing.Size(659, 268);
            this.GridCommandes.TabIndex = 5;
            // 
            // InputElement
            // 
            this.InputElement.Location = new System.Drawing.Point(15, 134);
            this.InputElement.Name = "InputElement";
            this.InputElement.Size = new System.Drawing.Size(226, 20);
            this.InputElement.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ajouter Element";
            // 
            // VibratoCircle
            // 
            this.VibratoCircle.AutoSize = true;
            this.VibratoCircle.Location = new System.Drawing.Point(15, 177);
            this.VibratoCircle.Name = "VibratoCircle";
            this.VibratoCircle.Size = new System.Drawing.Size(105, 17);
            this.VibratoCircle.TabIndex = 8;
            this.VibratoCircle.TabStop = true;
            this.VibratoCircle.Text = "Nouveau Vibrato";
            this.VibratoCircle.UseVisualStyleBackColor = true;
            // 
            // TypeBoisCircle
            // 
            this.TypeBoisCircle.AutoSize = true;
            this.TypeBoisCircle.Location = new System.Drawing.Point(15, 223);
            this.TypeBoisCircle.Name = "TypeBoisCircle";
            this.TypeBoisCircle.Size = new System.Drawing.Size(134, 17);
            this.TypeBoisCircle.TabIndex = 9;
            this.TypeBoisCircle.TabStop = true;
            this.TypeBoisCircle.Text = "Nouveau Type de Bois";
            this.TypeBoisCircle.UseVisualStyleBackColor = true;
            // 
            // MicroCircle
            // 
            this.MicroCircle.AutoSize = true;
            this.MicroCircle.Location = new System.Drawing.Point(15, 200);
            this.MicroCircle.Name = "MicroCircle";
            this.MicroCircle.Size = new System.Drawing.Size(161, 17);
            this.MicroCircle.TabIndex = 10;
            this.MicroCircle.TabStop = true;
            this.MicroCircle.Text = "Nouveau Constructeur Micro";
            this.MicroCircle.UseVisualStyleBackColor = true;
            // 
            // EffacerEl
            // 
            this.EffacerEl.Location = new System.Drawing.Point(136, 269);
            this.EffacerEl.Name = "EffacerEl";
            this.EffacerEl.Size = new System.Drawing.Size(105, 52);
            this.EffacerEl.TabIndex = 12;
            this.EffacerEl.Text = "Effacer Element Selectionné";
            this.EffacerEl.UseVisualStyleBackColor = true;
            this.EffacerEl.Click += new System.EventHandler(this.EffacerEl_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(15, 269);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(115, 52);
            this.Ajouter.TabIndex = 13;
            this.Ajouter.Text = "Ajouter Nouvel Element";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // EffacerCommandeBtn
            // 
            this.EffacerCommandeBtn.Location = new System.Drawing.Point(287, 526);
            this.EffacerCommandeBtn.Name = "EffacerCommandeBtn";
            this.EffacerCommandeBtn.Size = new System.Drawing.Size(105, 52);
            this.EffacerCommandeBtn.TabIndex = 14;
            this.EffacerCommandeBtn.Text = "Effacer Commande Selecctionnée";
            this.EffacerCommandeBtn.UseVisualStyleBackColor = true;
            this.EffacerCommandeBtn.Click += new System.EventHandler(this.EffacerCommandeBtn_Click);
            // 
            // nroCommandeDataGridViewTextBoxColumn
            // 
            this.nroCommandeDataGridViewTextBoxColumn.DataPropertyName = "NroCommande";
            this.nroCommandeDataGridViewTextBoxColumn.HeaderText = "NroCommande";
            this.nroCommandeDataGridViewTextBoxColumn.Name = "nroCommandeDataGridViewTextBoxColumn";
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // nomguitarDataGridViewTextBoxColumn
            // 
            this.nomguitarDataGridViewTextBoxColumn.DataPropertyName = "Nomguitar";
            this.nomguitarDataGridViewTextBoxColumn.HeaderText = "Nomguitar";
            this.nomguitarDataGridViewTextBoxColumn.Name = "nomguitarDataGridViewTextBoxColumn";
            // 
            // mPos1DataGridViewTextBoxColumn
            // 
            this.mPos1DataGridViewTextBoxColumn.DataPropertyName = "M_Pos_1";
            this.mPos1DataGridViewTextBoxColumn.HeaderText = "M_Pos_1";
            this.mPos1DataGridViewTextBoxColumn.Name = "mPos1DataGridViewTextBoxColumn";
            // 
            // mPos2DataGridViewTextBoxColumn
            // 
            this.mPos2DataGridViewTextBoxColumn.DataPropertyName = "M_Pos_2";
            this.mPos2DataGridViewTextBoxColumn.HeaderText = "M_Pos_2";
            this.mPos2DataGridViewTextBoxColumn.Name = "mPos2DataGridViewTextBoxColumn";
            // 
            // mPos3DataGridViewTextBoxColumn
            // 
            this.mPos3DataGridViewTextBoxColumn.DataPropertyName = "M_Pos_3";
            this.mPos3DataGridViewTextBoxColumn.HeaderText = "M_Pos_3";
            this.mPos3DataGridViewTextBoxColumn.Name = "mPos3DataGridViewTextBoxColumn";
            // 
            // boisCorpsDataGridViewTextBoxColumn
            // 
            this.boisCorpsDataGridViewTextBoxColumn.DataPropertyName = "Bois_Corps";
            this.boisCorpsDataGridViewTextBoxColumn.HeaderText = "Bois_Corps";
            this.boisCorpsDataGridViewTextBoxColumn.Name = "boisCorpsDataGridViewTextBoxColumn";
            // 
            // boisToucheDataGridViewTextBoxColumn
            // 
            this.boisToucheDataGridViewTextBoxColumn.DataPropertyName = "Bois_Touche";
            this.boisToucheDataGridViewTextBoxColumn.HeaderText = "Bois_Touche";
            this.boisToucheDataGridViewTextBoxColumn.Name = "boisToucheDataGridViewTextBoxColumn";
            // 
            // boisMancheDataGridViewTextBoxColumn
            // 
            this.boisMancheDataGridViewTextBoxColumn.DataPropertyName = "Bois_Manche";
            this.boisMancheDataGridViewTextBoxColumn.HeaderText = "Bois_Manche";
            this.boisMancheDataGridViewTextBoxColumn.Name = "boisMancheDataGridViewTextBoxColumn";
            // 
            // dateCommandeDataGridViewTextBoxColumn
            // 
            this.dateCommandeDataGridViewTextBoxColumn.DataPropertyName = "DateCommande";
            this.dateCommandeDataGridViewTextBoxColumn.HeaderText = "DateCommande";
            this.dateCommandeDataGridViewTextBoxColumn.Name = "dateCommandeDataGridViewTextBoxColumn";
            // 
            // montantDataGridViewTextBoxColumn
            // 
            this.montantDataGridViewTextBoxColumn.DataPropertyName = "Montant";
            this.montantDataGridViewTextBoxColumn.HeaderText = "Montant";
            this.montantDataGridViewTextBoxColumn.Name = "montantDataGridViewTextBoxColumn";
            // 
            // cBONCOMMANDEBindingSource
            // 
            this.cBONCOMMANDEBindingSource.DataSource = typeof(TP_Guitar_Frabiquant.WS_Guitar.C_BON_COMMANDE);
            // 
            // EditionEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 636);
            this.Controls.Add(this.EffacerCommandeBtn);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.EffacerEl);
            this.Controls.Add(this.MicroCircle);
            this.Controls.Add(this.TypeBoisCircle);
            this.Controls.Add(this.VibratoCircle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputElement);
            this.Controls.Add(this.GridCommandes);
            this.Controls.Add(this.ItemsList);
            this.Controls.Add(this.MontrerBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemToShowCbx);
            this.Name = "EditionEntreprise";
            this.Text = "Edition Entreprise";
            ((System.ComponentModel.ISupportInitialize)(this.GridCommandes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBONCOMMANDEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ItemToShowCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MontrerBtn;
        private System.Windows.Forms.ListBox ItemsList;
        private System.Windows.Forms.DataGridView GridCommandes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomguitarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPos1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPos2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPos3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boisCorpsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boisToucheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boisMancheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cBONCOMMANDEBindingSource;
        private System.Windows.Forms.TextBox InputElement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton VibratoCircle;
        private System.Windows.Forms.RadioButton TypeBoisCircle;
        private System.Windows.Forms.RadioButton MicroCircle;
        private System.Windows.Forms.Button EffacerEl;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button EffacerCommandeBtn;
    }
}

