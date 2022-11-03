namespace ExerciciosWindowsForms11
{
    partial class Form_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_principal));
            this.Nome_Completo = new System.Windows.Forms.TextBox();
            this.Inserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lista_Nomes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Nome_Completo
            // 
            resources.ApplyResources(this.Nome_Completo, "Nome_Completo");
            this.Nome_Completo.Name = "Nome_Completo";
            // 
            // Inserir
            // 
            resources.ApplyResources(this.Inserir, "Inserir");
            this.Inserir.Name = "Inserir";
            this.Inserir.UseVisualStyleBackColor = true;
            this.Inserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Lista_Nomes
            // 
            resources.ApplyResources(this.Lista_Nomes, "Lista_Nomes");
            this.Lista_Nomes.Name = "Lista_Nomes";
            // 
            // Form_principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lista_Nomes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inserir);
            this.Controls.Add(this.Nome_Completo);
            this.Name = "Form_principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Nome_Completo;
        private Button Inserir;
        private Label label1;
        private TextBox Lista_Nomes;
    }
}