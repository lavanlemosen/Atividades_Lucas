namespace Atividade1;

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
        Lb_Titulo = new Label();
        Lb_Largura = new Label();
        LarguraBox = new TextBox();
        ComprimentoBox = new TextBox();
        Lb_Comprimento = new Label();
        Bt_Calcular = new Button();
        SuspendLayout();
        // 
        // Lb_Titulo
        // 
        Lb_Titulo.AutoSize = true;
        Lb_Titulo.Location = new Point(67, 9);
        Lb_Titulo.Name = "Lb_Titulo";
        Lb_Titulo.Size = new Size(72, 20);
        Lb_Titulo.TabIndex = 0;
        Lb_Titulo.Text = "Imobilis";
        // 
        // Lb_Largura
        // 
        Lb_Largura.AutoSize = true;
        Lb_Largura.Location = new Point(12, 58);
        Lb_Largura.Name = "Lb_Largura";
        Lb_Largura.Size = new Size(69, 20);
        Lb_Largura.TabIndex = 1;
        Lb_Largura.Text = "Largura\r\n";
        // 
        // LarguraBox
        // 
        LarguraBox.Location = new Point(12, 81);
        LarguraBox.Name = "LarguraBox";
        LarguraBox.Size = new Size(176, 29);
        LarguraBox.TabIndex = 2;
        LarguraBox.Text = "Digite a Largura";
        LarguraBox.Enter += LarguraBox_Enter;
        LarguraBox.KeyPress += LarguraBox_KeyPress;
        LarguraBox.Leave += LarguraBox_Leave;
        // 
        // ComprimentoBox
        // 
        ComprimentoBox.Location = new Point(12, 184);
        ComprimentoBox.Name = "ComprimentoBox";
        ComprimentoBox.Size = new Size(176, 29);
        ComprimentoBox.TabIndex = 4;
        ComprimentoBox.Text = "Digite o Comprimento";
        ComprimentoBox.Enter += textBox1_Enter;
        ComprimentoBox.KeyPress += ComprimentoBox_KeyPress;
        ComprimentoBox.Leave += ComprimentoBox_Leave;
        // 
        // Lb_Comprimento
        // 
        Lb_Comprimento.AutoSize = true;
        Lb_Comprimento.Location = new Point(12, 161);
        Lb_Comprimento.Name = "Lb_Comprimento";
        Lb_Comprimento.Size = new Size(116, 20);
        Lb_Comprimento.TabIndex = 3;
        Lb_Comprimento.Text = "Comprimento\r\n";
        // 
        // Bt_Calcular
        // 
        Bt_Calcular.Location = new Point(52, 236);
        Bt_Calcular.Name = "Bt_Calcular";
        Bt_Calcular.Size = new Size(87, 29);
        Bt_Calcular.TabIndex = 5;
        Bt_Calcular.Text = "Calcular";
        Bt_Calcular.UseVisualStyleBackColor = true;
        Bt_Calcular.Click += Bt_Calcular_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(11F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(211, 277);
        Controls.Add(Bt_Calcular);
        Controls.Add(ComprimentoBox);
        Controls.Add(Lb_Comprimento);
        Controls.Add(LarguraBox);
        Controls.Add(Lb_Largura);
        Controls.Add(Lb_Titulo);
        Font = new Font("Mongolian Baiti", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(5, 4, 5, 4);
        Name = "Form1";
        Text = "Imobilis";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label Lb_Titulo;
    private Label Lb_Largura;
    private TextBox LarguraBox;
    private TextBox ComprimentoBox;
    private Label Lb_Comprimento;
    private Button Bt_Calcular;
}