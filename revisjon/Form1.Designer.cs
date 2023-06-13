namespace revisjon
{
    partial class Form1
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
            bt_divisao = new Button();
            tx_valor1 = new TextBox();
            tx_valor2 = new TextBox();
            bt_calcular = new Button();
            lb_resultado = new Label();
            rbt_a = new RadioButton();
            rbt_b = new RadioButton();
            button1 = new Button();
            lb_resposta = new Label();
            SuspendLayout();
            // 
            // bt_divisao
            // 
            bt_divisao.Location = new Point(573, 183);
            bt_divisao.Name = "bt_divisao";
            bt_divisao.Size = new Size(75, 23);
            bt_divisao.TabIndex = 0;
            bt_divisao.Text = "calcular";
            bt_divisao.UseVisualStyleBackColor = true;
            bt_divisao.Click += button1_Click;
            // 
            // tx_valor1
            // 
            tx_valor1.Location = new Point(327, 59);
            tx_valor1.Name = "tx_valor1";
            tx_valor1.Size = new Size(100, 23);
            tx_valor1.TabIndex = 1;
            // 
            // tx_valor2
            // 
            tx_valor2.Location = new Point(327, 101);
            tx_valor2.Name = "tx_valor2";
            tx_valor2.Size = new Size(100, 23);
            tx_valor2.TabIndex = 2;
            // 
            // bt_calcular
            // 
            bt_calcular.Location = new Point(327, 158);
            bt_calcular.Name = "bt_calcular";
            bt_calcular.Size = new Size(75, 23);
            bt_calcular.TabIndex = 3;
            bt_calcular.Text = "calcular";
            bt_calcular.UseVisualStyleBackColor = true;
            bt_calcular.Click += bt_calcular_Click;
            // 
            // lb_resultado
            // 
            lb_resultado.AutoSize = true;
            lb_resultado.Location = new Point(469, 144);
            lb_resultado.Name = "lb_resultado";
            lb_resultado.Size = new Size(38, 15);
            lb_resultado.TabIndex = 4;
            lb_resultado.Text = "label1";
            // 
            // rbt_a
            // 
            rbt_a.AutoSize = true;
            rbt_a.Location = new Point(263, 238);
            rbt_a.Name = "rbt_a";
            rbt_a.Size = new Size(80, 19);
            rbt_a.TabIndex = 5;
            rbt_a.TabStop = true;
            rbt_a.Text = "Masculino";
            rbt_a.UseVisualStyleBackColor = true;
            rbt_a.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbt_b
            // 
            rbt_b.AutoSize = true;
            rbt_b.Location = new Point(262, 283);
            rbt_b.Name = "rbt_b";
            rbt_b.Size = new Size(75, 19);
            rbt_b.TabIndex = 6;
            rbt_b.TabStop = true;
            rbt_b.Text = "Feminino";
            rbt_b.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(268, 320);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Como você se identifica?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // lb_resposta
            // 
            lb_resposta.AutoSize = true;
            lb_resposta.Location = new Point(273, 357);
            lb_resposta.Name = "lb_resposta";
            lb_resposta.Size = new Size(38, 15);
            lb_resposta.TabIndex = 8;
            lb_resposta.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_resposta);
            Controls.Add(button1);
            Controls.Add(rbt_b);
            Controls.Add(rbt_a);
            Controls.Add(lb_resultado);
            Controls.Add(bt_calcular);
            Controls.Add(tx_valor2);
            Controls.Add(tx_valor1);
            Controls.Add(bt_divisao);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_divisao;
        private TextBox tx_valor1;
        private TextBox tx_valor2;
        private Button bt_calcular;
        private Label lb_resultado;
        private RadioButton rbt_a;
        private RadioButton rbt_b;
        private Button button1;
        private Label lb_resposta;
    }
}