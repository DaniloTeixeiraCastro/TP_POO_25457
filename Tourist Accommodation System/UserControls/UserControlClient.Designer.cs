namespace Tourist_Accommodation_System
{
    public partial class UserControlClient : UserControl
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            button_listclient = new Button();
            button_removeclient = new Button();
            button_editclient = new Button();
            button_addclient = new Button();
            button_back = new Button();
            SuspendLayout();
            // 
            // button_listclient
            // 
            button_listclient.Location = new Point(134, 384);
            button_listclient.Name = "button_listclient";
            button_listclient.Size = new Size(297, 69);
            button_listclient.TabIndex = 8;
            button_listclient.Text = "LIST CLIENT";
            button_listclient.UseVisualStyleBackColor = true;
            button_listclient.Click += button_listclient_Click;
            // 
            // button_removeclient
            // 
            button_removeclient.Location = new Point(134, 279);
            button_removeclient.Name = "button_removeclient";
            button_removeclient.Size = new Size(297, 69);
            button_removeclient.TabIndex = 7;
            button_removeclient.Text = "REMOVE CLIENT";
            button_removeclient.UseVisualStyleBackColor = true;
            button_removeclient.Click += button_removeclient_Click;
            // 
            // button_editclient
            // 
            button_editclient.Location = new Point(134, 183);
            button_editclient.Name = "button_editclient";
            button_editclient.Size = new Size(297, 74);
            button_editclient.TabIndex = 6;
            button_editclient.Text = "EDIT CLIENT";
            button_editclient.UseVisualStyleBackColor = true;
            button_editclient.Click += button_editclient_Click;
            // 
            // button_addclient
            // 
            button_addclient.Location = new Point(134, 82);
            button_addclient.Name = "button_addclient";
            button_addclient.Size = new Size(297, 74);
            button_addclient.TabIndex = 5;
            button_addclient.Text = "ADD CLIENT";
            button_addclient.UseVisualStyleBackColor = true;
            button_addclient.Click += button_addclient_Click;
            // 
            // button_back
            // 
            button_back.BackColor = Color.Transparent;
            button_back.Location = new Point(469, 82);
            button_back.Name = "button_back";
            button_back.Size = new Size(205, 44);
            button_back.TabIndex = 9;
            button_back.Text = "<-";
            button_back.UseVisualStyleBackColor = false;
            button_back.Click += button_back_Click;
            // 
            // UserControlClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_back);
            Controls.Add(button_listclient);
            Controls.Add(button_removeclient);
            Controls.Add(button_editclient);
            Controls.Add(button_addclient);
            Name = "UserControlClient";
            Size = new Size(1010, 596);
            ResumeLayout(false);
        }

        #endregion

        private Button button_listclient;
        private Button button_removeclient;
        private Button button_editclient;
        private Button button_addclient;
        private Button button_back;
    }
}
