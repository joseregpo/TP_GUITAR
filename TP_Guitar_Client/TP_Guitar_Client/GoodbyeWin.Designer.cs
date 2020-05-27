namespace TP_Guitar_Client
{
    partial class GoodbyeWin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RecommanderBtn = new System.Windows.Forms.Button();
            this.FinirBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BonCommandeView = new System.Windows.Forms.DataGridView();
            this.cBONCOMMANDEBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.BonCommandeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBONCOMMANDEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(64, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merci Pour Votre Commande!!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(68, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Un Conseiller vous contactera dans les meilleurs délais!";
            // 
            // RecommanderBtn
            // 
            this.RecommanderBtn.Location = new System.Drawing.Point(51, 391);
            this.RecommanderBtn.Name = "RecommanderBtn";
            this.RecommanderBtn.Size = new System.Drawing.Size(151, 58);
            this.RecommanderBtn.TabIndex = 3;
            this.RecommanderBtn.Text = "Passer Une Autre Commande";
            this.RecommanderBtn.UseVisualStyleBackColor = true;
            // 
            // FinirBtn
            // 
            this.FinirBtn.Location = new System.Drawing.Point(267, 391);
            this.FinirBtn.Name = "FinirBtn";
            this.FinirBtn.Size = new System.Drawing.Size(158, 58);
            this.FinirBtn.TabIndex = 4;
            this.FinirBtn.Text = "Sortir";
            this.FinirBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Voici Votre Bon de Commande!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BonCommandeView
            // 
            this.BonCommandeView.AutoGenerateColumns = false;
            this.BonCommandeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BonCommandeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.BonCommandeView.DataSource = this.cBONCOMMANDEBindingSource;
            this.BonCommandeView.Location = new System.Drawing.Point(34, 159);
            this.BonCommandeView.Name = "BonCommandeView";
            this.BonCommandeView.Size = new System.Drawing.Size(451, 183);
            this.BonCommandeView.TabIndex = 6;
            this.BonCommandeView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BonCommandeView_CellContentClick);
            // 
            // cBONCOMMANDEBindingSource
            // 
            this.cBONCOMMANDEBindingSource.DataSource = typeof(TP_Guitar_Client.WS_GUITAR_Client.C_BON_COMMANDE);
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
            // GoodbyeWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 512);
            this.Controls.Add(this.BonCommandeView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FinirBtn);
            this.Controls.Add(this.RecommanderBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "GoodbyeWin";
            this.Text = "Fin de Commande";
            this.Load += new System.EventHandler(this.GoodbyeWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BonCommandeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBONCOMMANDEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RecommanderBtn;
        private System.Windows.Forms.Button FinirBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView BonCommandeView;
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
    }
}