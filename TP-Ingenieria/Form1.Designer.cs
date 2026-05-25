namespace TP_Ingenieria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnIngresar = new ReaLTaiizor.Controls.HopeButton();
            this.txtClave = new ReaLTaiizor.Controls.HopeTextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtUsuario = new ReaLTaiizor.Controls.HopeTextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.panelLogin.Controls.Add(this.lblMensaje);
            this.panelLogin.Controls.Add(this.btnIngresar);
            this.panelLogin.Controls.Add(this.txtClave);
            this.panelLogin.Controls.Add(this.lblClave);
            this.panelLogin.Controls.Add(this.txtUsuario);
            this.panelLogin.Controls.Add(this.lblUsuario);
            this.panelLogin.Controls.Add(this.lblSubtitulo);
            this.panelLogin.Controls.Add(this.lblTitulo);
            this.panelLogin.Location = new System.Drawing.Point(210, 48);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(380, 392);
            this.panelLogin.TabIndex = 0;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(67)))), ((int)(((byte)(45)))));
            this.lblMensaje.Location = new System.Drawing.Point(42, 326);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(296, 34);
            this.lblMensaje.TabIndex = 7;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(62)))), ((int)(((byte)(43)))));
            this.btnIngresar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnIngresar.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.HoverTextColor = System.Drawing.Color.White;
            this.btnIngresar.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnIngresar.Location = new System.Drawing.Point(42, 274);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(62)))), ((int)(((byte)(43)))));
            this.btnIngresar.Size = new System.Drawing.Size(296, 42);
            this.btnIngresar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextColor = System.Drawing.Color.White;
            this.btnIngresar.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.White;
            this.txtClave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.txtClave.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(202)))), ((int)(((byte)(184)))));
            this.txtClave.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(202)))), ((int)(((byte)(184)))));
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(45)))), ((int)(((byte)(35)))));
            this.txtClave.Hint = "Ingrese su clave";
            this.txtClave.Location = new System.Drawing.Point(42, 217);
            this.txtClave.MaxLength = 32767;
            this.txtClave.Multiline = false;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClave.SelectedText = "";
            this.txtClave.SelectionLength = 0;
            this.txtClave.SelectionStart = 0;
            this.txtClave.Size = new System.Drawing.Size(296, 39);
            this.txtClave.TabIndex = 5;
            this.txtClave.TabStop = false;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(62)))), ((int)(((byte)(43)))));
            this.lblClave.Location = new System.Drawing.Point(42, 193);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(49, 21);
            this.lblClave.TabIndex = 4;
            this.lblClave.Text = "Clave";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.txtUsuario.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(202)))), ((int)(((byte)(184)))));
            this.txtUsuario.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(202)))), ((int)(((byte)(184)))));
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(45)))), ((int)(((byte)(35)))));
            this.txtUsuario.Hint = "Ingrese su usuario";
            this.txtUsuario.Location = new System.Drawing.Point(42, 139);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(296, 39);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(62)))), ((int)(((byte)(43)))));
            this.lblUsuario.Location = new System.Drawing.Point(42, 115);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 21);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(101)))), ((int)(((byte)(82)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(42, 70);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(296, 24);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Inicio de sesion";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(47)))), ((int)(((byte)(33)))));
            this.lblTitulo.Location = new System.Drawing.Point(42, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(296, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Salem Coffee Shop";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.panelLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salem Coffee Shop - Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuario;
        private ReaLTaiizor.Controls.HopeTextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private ReaLTaiizor.Controls.HopeTextBox txtClave;
        private ReaLTaiizor.Controls.HopeButton btnIngresar;
        private System.Windows.Forms.Label lblMensaje;
    }
}

