﻿namespace Tourist_Accommodation_System
{
    partial class UserControlReview
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
            button_listreview = new Button();
            button_removereview = new Button();
            button_editreview = new Button();
            button_addreview = new Button();
            button_back = new Button();
            SuspendLayout();
            // 
            // button_listreview
            // 
            button_listreview.Location = new Point(362, 327);
            button_listreview.Name = "button_listreview";
            button_listreview.Size = new Size(212, 83);
            button_listreview.TabIndex = 7;
            button_listreview.Text = "LIST REVIEW";
            button_listreview.UseVisualStyleBackColor = true;
            button_listreview.Click += button_listreview_Click;
            // 
            // button_removereview
            // 
            button_removereview.Location = new Point(362, 252);
            button_removereview.Name = "button_removereview";
            button_removereview.Size = new Size(212, 69);
            button_removereview.TabIndex = 6;
            button_removereview.Text = "REMOVE REVIEW";
            button_removereview.UseVisualStyleBackColor = true;
            button_removereview.Click += button_removereview_Click;
            // 
            // button_editreview
            // 
            button_editreview.Location = new Point(362, 185);
            button_editreview.Name = "button_editreview";
            button_editreview.Size = new Size(212, 66);
            button_editreview.TabIndex = 5;
            button_editreview.Text = "EDIT REVIEW";
            button_editreview.UseVisualStyleBackColor = true;
            button_editreview.Click += button_editreview_Click;
            // 
            // button_addreview
            // 
            button_addreview.Location = new Point(362, 106);
            button_addreview.Name = "button_addreview";
            button_addreview.Size = new Size(212, 73);
            button_addreview.TabIndex = 4;
            button_addreview.Text = "ADD REVIEW";
            button_addreview.UseVisualStyleBackColor = true;
            button_addreview.Click += button_addreview_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(633, 111);
            button_back.Name = "button_back";
            button_back.Size = new Size(53, 62);
            button_back.TabIndex = 8;
            button_back.Text = "<-";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // UserControlReview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_back);
            Controls.Add(button_listreview);
            Controls.Add(button_removereview);
            Controls.Add(button_editreview);
            Controls.Add(button_addreview);
            Name = "UserControlReview";
            Size = new Size(1000, 590);
            Load += UserControlReview_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button_listreview;
        private Button button_removereview;
        private Button button_editreview;
        private Button button_addreview;
        private Button button_back;
    }
}
