namespace WindowsFormsApp3
{
    partial class Form1
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxLogin = new System.Windows.Forms.GroupBox();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.boxGeral = new System.Windows.Forms.GroupBox();
            this.buttonAgenda = new System.Windows.Forms.Button();
            this.buttonVenda = new System.Windows.Forms.Button();
            this.buttonAluga = new System.Windows.Forms.Button();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.buttonAtualiza = new System.Windows.Forms.Button();
            this.labelDvds = new System.Windows.Forms.Label();
            this.labelRevistas = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtLivroValor = new System.Windows.Forms.TextBox();
            this.boxUsuario = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dateAgendamento = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtVendaQuantidade = new System.Windows.Forms.TextBox();
            this.buttonFinalizaVenda = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLivroDisponiveis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelLivros = new System.Windows.Forms.Label();
            this.comboLivroTitulo = new System.Windows.Forms.ComboBox();
            this.comboLivroGenero = new System.Windows.Forms.ComboBox();
            this.comboLivroAutor = new System.Windows.Forms.ComboBox();
            this.buttonNewUsuario = new System.Windows.Forms.Button();
            this.buttonNewProduto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLogoffAdmin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boxAdmin = new System.Windows.Forms.GroupBox();
            this.comboTipoProduto = new System.Windows.Forms.ComboBox();
            this.boxCadastros = new System.Windows.Forms.GroupBox();
            this.buttonAgendamentosEfetuados = new System.Windows.Forms.Button();
            this.buttonMenuAlugueis = new System.Windows.Forms.Button();
            this.boxLogin.SuspendLayout();
            this.boxGeral.SuspendLayout();
            this.boxUsuario.SuspendLayout();
            this.boxAdmin.SuspendLayout();
            this.boxCadastros.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.AcceptsReturn = true;
            this.txtLogin.Location = new System.Drawing.Point(33, 62);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(33, 101);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Acesso ao Sistema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // boxLogin
            // 
            this.boxLogin.Controls.Add(this.buttonConectar);
            this.boxLogin.Controls.Add(this.label3);
            this.boxLogin.Controls.Add(this.label2);
            this.boxLogin.Controls.Add(this.label1);
            this.boxLogin.Controls.Add(this.txtSenha);
            this.boxLogin.Controls.Add(this.txtLogin);
            this.boxLogin.Location = new System.Drawing.Point(12, 12);
            this.boxLogin.Name = "boxLogin";
            this.boxLogin.Size = new System.Drawing.Size(173, 177);
            this.boxLogin.TabIndex = 7;
            this.boxLogin.TabStop = false;
            // 
            // buttonConectar
            // 
            this.buttonConectar.Location = new System.Drawing.Point(45, 142);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(75, 23);
            this.buttonConectar.TabIndex = 7;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // boxGeral
            // 
            this.boxGeral.Controls.Add(this.buttonAgenda);
            this.boxGeral.Controls.Add(this.buttonVenda);
            this.boxGeral.Controls.Add(this.buttonAluga);
            this.boxGeral.Controls.Add(this.buttonComprar);
            this.boxGeral.Controls.Add(this.buttonAtualiza);
            this.boxGeral.Controls.Add(this.labelDvds);
            this.boxGeral.Controls.Add(this.labelRevistas);
            this.boxGeral.Controls.Add(this.label17);
            this.boxGeral.Controls.Add(this.txtLivroValor);
            this.boxGeral.Controls.Add(this.boxUsuario);
            this.boxGeral.Controls.Add(this.label13);
            this.boxGeral.Controls.Add(this.txtLivroDisponiveis);
            this.boxGeral.Controls.Add(this.label11);
            this.boxGeral.Controls.Add(this.label10);
            this.boxGeral.Controls.Add(this.label9);
            this.boxGeral.Controls.Add(this.labelLivros);
            this.boxGeral.Controls.Add(this.comboLivroTitulo);
            this.boxGeral.Controls.Add(this.comboLivroGenero);
            this.boxGeral.Controls.Add(this.comboLivroAutor);
            this.boxGeral.ForeColor = System.Drawing.SystemColors.ControlText;
            this.boxGeral.Location = new System.Drawing.Point(12, 201);
            this.boxGeral.Name = "boxGeral";
            this.boxGeral.Size = new System.Drawing.Size(705, 410);
            this.boxGeral.TabIndex = 10;
            this.boxGeral.TabStop = false;
            this.boxGeral.Visible = false;
            // 
            // buttonAgenda
            // 
            this.buttonAgenda.Location = new System.Drawing.Point(624, 366);
            this.buttonAgenda.Name = "buttonAgenda";
            this.buttonAgenda.Size = new System.Drawing.Size(75, 23);
            this.buttonAgenda.TabIndex = 16;
            this.buttonAgenda.Text = "Agenda";
            this.buttonAgenda.UseVisualStyleBackColor = true;
            this.buttonAgenda.Click += new System.EventHandler(this.buttonAgenda_Click);
            // 
            // buttonVenda
            // 
            this.buttonVenda.Location = new System.Drawing.Point(462, 366);
            this.buttonVenda.Name = "buttonVenda";
            this.buttonVenda.Size = new System.Drawing.Size(75, 23);
            this.buttonVenda.TabIndex = 14;
            this.buttonVenda.Text = "Venda";
            this.buttonVenda.UseVisualStyleBackColor = true;
            this.buttonVenda.Click += new System.EventHandler(this.buttonVenda_Click);
            // 
            // buttonAluga
            // 
            this.buttonAluga.Location = new System.Drawing.Point(543, 366);
            this.buttonAluga.Name = "buttonAluga";
            this.buttonAluga.Size = new System.Drawing.Size(75, 23);
            this.buttonAluga.TabIndex = 15;
            this.buttonAluga.Text = "Aluga";
            this.buttonAluga.UseVisualStyleBackColor = true;
            this.buttonAluga.Click += new System.EventHandler(this.buttonAluga_Click);
            // 
            // buttonComprar
            // 
            this.buttonComprar.Location = new System.Drawing.Point(273, 323);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(140, 23);
            this.buttonComprar.TabIndex = 25;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // buttonAtualiza
            // 
            this.buttonAtualiza.Location = new System.Drawing.Point(605, 25);
            this.buttonAtualiza.Name = "buttonAtualiza";
            this.buttonAtualiza.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualiza.TabIndex = 24;
            this.buttonAtualiza.Text = "Atualizar";
            this.buttonAtualiza.UseVisualStyleBackColor = true;
            this.buttonAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // labelDvds
            // 
            this.labelDvds.AutoSize = true;
            this.labelDvds.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDvds.Location = new System.Drawing.Point(213, 25);
            this.labelDvds.Name = "labelDvds";
            this.labelDvds.Size = new System.Drawing.Size(69, 25);
            this.labelDvds.TabIndex = 23;
            this.labelDvds.Text = "DVDs";
            this.labelDvds.Visible = false;
            // 
            // labelRevistas
            // 
            this.labelRevistas.AutoSize = true;
            this.labelRevistas.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRevistas.Location = new System.Drawing.Point(106, 25);
            this.labelRevistas.Name = "labelRevistas";
            this.labelRevistas.Size = new System.Drawing.Size(101, 25);
            this.labelRevistas.TabIndex = 22;
            this.labelRevistas.Text = "Revistas";
            this.labelRevistas.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(24, 246);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 14);
            this.label17.TabIndex = 21;
            this.label17.Text = "Valor:";
            // 
            // txtLivroValor
            // 
            this.txtLivroValor.Enabled = false;
            this.txtLivroValor.Location = new System.Drawing.Point(27, 263);
            this.txtLivroValor.Name = "txtLivroValor";
            this.txtLivroValor.Size = new System.Drawing.Size(100, 20);
            this.txtLivroValor.TabIndex = 20;
            // 
            // boxUsuario
            // 
            this.boxUsuario.Controls.Add(this.label18);
            this.boxUsuario.Controls.Add(this.dateAgendamento);
            this.boxUsuario.Controls.Add(this.label12);
            this.boxUsuario.Controls.Add(this.txtEmailCliente);
            this.boxUsuario.Controls.Add(this.label16);
            this.boxUsuario.Controls.Add(this.txtVendaQuantidade);
            this.boxUsuario.Controls.Add(this.buttonFinalizaVenda);
            this.boxUsuario.Controls.Add(this.label15);
            this.boxUsuario.Controls.Add(this.comboCliente);
            this.boxUsuario.Controls.Add(this.label14);
            this.boxUsuario.Location = new System.Drawing.Point(450, 118);
            this.boxUsuario.Name = "boxUsuario";
            this.boxUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxUsuario.Size = new System.Drawing.Size(246, 234);
            this.boxUsuario.TabIndex = 19;
            this.boxUsuario.TabStop = false;
            this.boxUsuario.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 169);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Data do agendamento:";
            // 
            // dateAgendamento
            // 
            this.dateAgendamento.Enabled = false;
            this.dateAgendamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAgendamento.Location = new System.Drawing.Point(6, 185);
            this.dateAgendamento.Name = "dateAgendamento";
            this.dateAgendamento.Size = new System.Drawing.Size(146, 20);
            this.dateAgendamento.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "E-mail:";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(6, 106);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(234, 20);
            this.txtEmailCliente.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Quantidade:";
            // 
            // txtVendaQuantidade
            // 
            this.txtVendaQuantidade.Location = new System.Drawing.Point(10, 145);
            this.txtVendaQuantidade.Name = "txtVendaQuantidade";
            this.txtVendaQuantidade.Size = new System.Drawing.Size(61, 20);
            this.txtVendaQuantidade.TabIndex = 4;
            this.txtVendaQuantidade.Text = "1";
            this.txtVendaQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonFinalizaVenda
            // 
            this.buttonFinalizaVenda.Location = new System.Drawing.Point(165, 205);
            this.buttonFinalizaVenda.Name = "buttonFinalizaVenda";
            this.buttonFinalizaVenda.Size = new System.Drawing.Size(75, 23);
            this.buttonFinalizaVenda.TabIndex = 3;
            this.buttonFinalizaVenda.Text = "Finalizar";
            this.buttonFinalizaVenda.UseVisualStyleBackColor = true;
            this.buttonFinalizaVenda.Click += new System.EventHandler(this.buttonFinalizaVenda_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Cliente:";
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(6, 63);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(234, 21);
            this.comboCliente.TabIndex = 1;
            this.comboCliente.SelectedIndexChanged += new System.EventHandler(this.comboCliente_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(209, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "INSIRA O FUNCIONARIO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 14);
            this.label13.TabIndex = 18;
            this.label13.Text = "Disponíveis:";
            // 
            // txtLivroDisponiveis
            // 
            this.txtLivroDisponiveis.Enabled = false;
            this.txtLivroDisponiveis.Location = new System.Drawing.Point(27, 223);
            this.txtLivroDisponiveis.Name = "txtLivroDisponiveis";
            this.txtLivroDisponiveis.Size = new System.Drawing.Size(100, 20);
            this.txtLivroDisponiveis.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 14);
            this.label11.TabIndex = 12;
            this.label11.Text = "Genero:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 14);
            this.label10.TabIndex = 11;
            this.label10.Text = "Autor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 14);
            this.label9.TabIndex = 10;
            this.label9.Text = "Título:";
            // 
            // labelLivros
            // 
            this.labelLivros.AutoSize = true;
            this.labelLivros.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLivros.Location = new System.Drawing.Point(22, 25);
            this.labelLivros.Name = "labelLivros";
            this.labelLivros.Size = new System.Drawing.Size(75, 25);
            this.labelLivros.TabIndex = 8;
            this.labelLivros.Text = "Livros";
            this.labelLivros.Visible = false;
            // 
            // comboLivroTitulo
            // 
            this.comboLivroTitulo.FormattingEnabled = true;
            this.comboLivroTitulo.Location = new System.Drawing.Point(27, 91);
            this.comboLivroTitulo.Name = "comboLivroTitulo";
            this.comboLivroTitulo.Size = new System.Drawing.Size(461, 21);
            this.comboLivroTitulo.TabIndex = 4;
            this.comboLivroTitulo.SelectedIndexChanged += new System.EventHandler(this.comboLivroTitulo_SelectedIndexChanged);
            // 
            // comboLivroGenero
            // 
            this.comboLivroGenero.Enabled = false;
            this.comboLivroGenero.FormattingEnabled = true;
            this.comboLivroGenero.Location = new System.Drawing.Point(27, 179);
            this.comboLivroGenero.Name = "comboLivroGenero";
            this.comboLivroGenero.Size = new System.Drawing.Size(288, 21);
            this.comboLivroGenero.TabIndex = 6;
            // 
            // comboLivroAutor
            // 
            this.comboLivroAutor.Enabled = false;
            this.comboLivroAutor.FormattingEnabled = true;
            this.comboLivroAutor.Location = new System.Drawing.Point(27, 134);
            this.comboLivroAutor.Name = "comboLivroAutor";
            this.comboLivroAutor.Size = new System.Drawing.Size(288, 21);
            this.comboLivroAutor.TabIndex = 5;
            // 
            // buttonNewUsuario
            // 
            this.buttonNewUsuario.Location = new System.Drawing.Point(6, 40);
            this.buttonNewUsuario.Name = "buttonNewUsuario";
            this.buttonNewUsuario.Size = new System.Drawing.Size(154, 23);
            this.buttonNewUsuario.TabIndex = 1;
            this.buttonNewUsuario.Text = "Cadastrar novo usuário";
            this.buttonNewUsuario.UseVisualStyleBackColor = true;
            this.buttonNewUsuario.Click += new System.EventHandler(this.buttonNewUsuario_Click);
            // 
            // buttonNewProduto
            // 
            this.buttonNewProduto.Location = new System.Drawing.Point(6, 11);
            this.buttonNewProduto.Name = "buttonNewProduto";
            this.buttonNewProduto.Size = new System.Drawing.Size(154, 23);
            this.buttonNewProduto.TabIndex = 0;
            this.buttonNewProduto.Text = "Cadastrar novo produto";
            this.buttonNewProduto.UseVisualStyleBackColor = true;
            this.buttonNewProduto.Click += new System.EventHandler(this.buttonNewProduto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // buttonLogoffAdmin
            // 
            this.buttonLogoffAdmin.Location = new System.Drawing.Point(445, 154);
            this.buttonLogoffAdmin.Name = "buttonLogoffAdmin";
            this.buttonLogoffAdmin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogoffAdmin.TabIndex = 2;
            this.buttonLogoffAdmin.Text = "Logoff";
            this.buttonLogoffAdmin.UseVisualStyleBackColor = true;
            this.buttonLogoffAdmin.Click += new System.EventHandler(this.buttonLogoffAdmin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pesquisa - Produtos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo:";
            // 
            // boxAdmin
            // 
            this.boxAdmin.Controls.Add(this.comboTipoProduto);
            this.boxAdmin.Controls.Add(this.boxCadastros);
            this.boxAdmin.Controls.Add(this.label6);
            this.boxAdmin.Controls.Add(this.label5);
            this.boxAdmin.Controls.Add(this.buttonLogoffAdmin);
            this.boxAdmin.Controls.Add(this.label4);
            this.boxAdmin.Location = new System.Drawing.Point(191, 12);
            this.boxAdmin.Name = "boxAdmin";
            this.boxAdmin.Size = new System.Drawing.Size(526, 183);
            this.boxAdmin.TabIndex = 8;
            this.boxAdmin.TabStop = false;
            this.boxAdmin.Text = "MenuAdmin";
            this.boxAdmin.Visible = false;
            // 
            // comboTipoProduto
            // 
            this.comboTipoProduto.FormattingEnabled = true;
            this.comboTipoProduto.Items.AddRange(new object[] {
            "Livros",
            "Revistas",
            "DVDs"});
            this.comboTipoProduto.Location = new System.Drawing.Point(60, 91);
            this.comboTipoProduto.Name = "comboTipoProduto";
            this.comboTipoProduto.Size = new System.Drawing.Size(256, 21);
            this.comboTipoProduto.TabIndex = 12;
            this.comboTipoProduto.SelectedIndexChanged += new System.EventHandler(this.comboTipoProduto_SelectedIndexChanged);
            // 
            // boxCadastros
            // 
            this.boxCadastros.Controls.Add(this.buttonAgendamentosEfetuados);
            this.boxCadastros.Controls.Add(this.buttonMenuAlugueis);
            this.boxCadastros.Controls.Add(this.buttonNewUsuario);
            this.boxCadastros.Controls.Add(this.buttonNewProduto);
            this.boxCadastros.Location = new System.Drawing.Point(350, 11);
            this.boxCadastros.Name = "boxCadastros";
            this.boxCadastros.Size = new System.Drawing.Size(167, 127);
            this.boxCadastros.TabIndex = 11;
            this.boxCadastros.TabStop = false;
            this.boxCadastros.Visible = false;
            // 
            // buttonAgendamentosEfetuados
            // 
            this.buttonAgendamentosEfetuados.Location = new System.Drawing.Point(6, 97);
            this.buttonAgendamentosEfetuados.Name = "buttonAgendamentosEfetuados";
            this.buttonAgendamentosEfetuados.Size = new System.Drawing.Size(154, 23);
            this.buttonAgendamentosEfetuados.TabIndex = 14;
            this.buttonAgendamentosEfetuados.Text = "Agendamentos Efetuados";
            this.buttonAgendamentosEfetuados.UseVisualStyleBackColor = true;
            this.buttonAgendamentosEfetuados.Click += new System.EventHandler(this.buttonAgendamentosEfetuados_Click);
            // 
            // buttonMenuAlugueis
            // 
            this.buttonMenuAlugueis.Location = new System.Drawing.Point(6, 68);
            this.buttonMenuAlugueis.Name = "buttonMenuAlugueis";
            this.buttonMenuAlugueis.Size = new System.Drawing.Size(154, 23);
            this.buttonMenuAlugueis.TabIndex = 13;
            this.buttonMenuAlugueis.Text = "Menu Aluguéis";
            this.buttonMenuAlugueis.UseVisualStyleBackColor = true;
            this.buttonMenuAlugueis.Click += new System.EventHandler(this.btnMenuAlugueis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 649);
            this.Controls.Add(this.boxGeral);
            this.Controls.Add(this.boxAdmin);
            this.Controls.Add(this.boxLogin);
            this.Name = "Form1";
            this.Text = "Biblioteca Cappta!";
            this.boxLogin.ResumeLayout(false);
            this.boxLogin.PerformLayout();
            this.boxGeral.ResumeLayout(false);
            this.boxGeral.PerformLayout();
            this.boxUsuario.ResumeLayout(false);
            this.boxUsuario.PerformLayout();
            this.boxAdmin.ResumeLayout(false);
            this.boxAdmin.PerformLayout();
            this.boxCadastros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox boxLogin;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.ComboBox comboLivroTitulo;
        private System.Windows.Forms.ComboBox comboLivroAutor;
        private System.Windows.Forms.ComboBox comboLivroGenero;
        private System.Windows.Forms.GroupBox boxGeral;
        private System.Windows.Forms.Label labelLivros;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLivroDisponiveis;
        private System.Windows.Forms.Button buttonAgenda;
        private System.Windows.Forms.Button buttonAluga;
        private System.Windows.Forms.Button buttonVenda;
        private System.Windows.Forms.GroupBox boxUsuario;
        private System.Windows.Forms.Button buttonFinalizaVenda;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonNewUsuario;
        private System.Windows.Forms.Button buttonNewProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLogoffAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox boxAdmin;
        private System.Windows.Forms.ComboBox comboTipoProduto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtVendaQuantidade;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtLivroValor;
        private System.Windows.Forms.Button buttonMenuAlugueis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateAgendamento;
        private System.Windows.Forms.Label labelDvds;
        private System.Windows.Forms.Label labelRevistas;
        private System.Windows.Forms.Button buttonAtualiza;
        private System.Windows.Forms.GroupBox boxCadastros;
        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.Button buttonAgendamentosEfetuados;
    }
}

