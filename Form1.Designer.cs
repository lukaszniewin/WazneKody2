
namespace WazneKody2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label operations;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.search_Lebel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.search_Result = new System.Windows.Forms.Label();
            this.Pole_Kodu = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.licznik_VjuS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            operations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // operations
            // 
            operations.AutoSize = true;
            operations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            operations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            operations.Location = new System.Drawing.Point(103, 83);
            operations.Name = "operations";
            operations.Size = new System.Drawing.Size(0, 20);
            operations.TabIndex = 2;
            operations.Tag = "";
            operations.Visible = false;
            // 
            // search_Lebel
            // 
            this.search_Lebel.AutoSize = true;
            this.search_Lebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.search_Lebel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.search_Lebel.Location = new System.Drawing.Point(92, 28);
            this.search_Lebel.Name = "search_Lebel";
            this.search_Lebel.Size = new System.Drawing.Size(180, 20);
            this.search_Lebel.TabIndex = 0;
            this.search_Lebel.Text = "Wpisz czego szukasz";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(115, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(56, 106);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 64);
            this.listBox1.TabIndex = 3;
            this.listBox1.Visible = false;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // search_Result
            // 
            this.search_Result.AutoSize = true;
            this.search_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.search_Result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.search_Result.Location = new System.Drawing.Point(112, 178);
            this.search_Result.Name = "search_Result";
            this.search_Result.Size = new System.Drawing.Size(146, 18);
            this.search_Result.TabIndex = 4;
            this.search_Result.Text = "Wynik wyszukania";
            this.search_Result.Visible = false;
            // 
            // Pole_Kodu
            // 
            this.Pole_Kodu.AutoEllipsis = true;
            this.Pole_Kodu.AutoSize = true;
            this.Pole_Kodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pole_Kodu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.Pole_Kodu.Location = new System.Drawing.Point(85, 201);
            this.Pole_Kodu.Name = "Pole_Kodu";
            this.Pole_Kodu.Size = new System.Drawing.Size(104, 16);
            this.Pole_Kodu.TabIndex = 5;
            this.Pole_Kodu.Text = "Kod Aktywacji";
            this.Pole_Kodu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.Pole_Kodu, "Kliknij 2 razy LPM aby skopiować! Zmiana tła = skopiowano");
            this.Pole_Kodu.Visible = false;
            this.Pole_Kodu.DoubleClick += new System.EventHandler(this.Pole_Kodu_DoubleClick);
            // 
            // licznik_VjuS
            // 
            this.licznik_VjuS.AutoSize = true;
            this.licznik_VjuS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.licznik_VjuS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.licznik_VjuS.Location = new System.Drawing.Point(191, 280);
            this.licznik_VjuS.Name = "licznik_VjuS";
            this.licznik_VjuS.Size = new System.Drawing.Size(45, 16);
            this.licznik_VjuS.TabIndex = 6;
            this.licznik_VjuS.Text = "label4";
            this.licznik_VjuS.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(103, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dostępne operacje";
            this.label1.Visible = false;
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipTitle = "2click";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(373, 301);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.licznik_VjuS);
            this.Controls.Add(this.Pole_Kodu);
            this.Controls.Add(this.search_Result);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(operations);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.search_Lebel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(389, 340);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ważne Kody";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ListBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label search_Lebel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label search_Result;
        private System.Windows.Forms.Label Pole_Kodu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label licznik_VjuS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

