<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTelaInicial
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTelaInicial))
        Me.amarelo = New System.Windows.Forms.Label()
        Me.lblverde = New System.Windows.Forms.Label()
        Me.lblazul = New System.Windows.Forms.Label()
        Me.lblvermelho = New System.Windows.Forms.Label()
        Me.lblpreto = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'amarelo
        '
        Me.amarelo.AutoSize = True
        Me.amarelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amarelo.ForeColor = System.Drawing.Color.Gold
        Me.amarelo.Location = New System.Drawing.Point(363, 172)
        Me.amarelo.Name = "amarelo"
        Me.amarelo.Size = New System.Drawing.Size(75, 20)
        Me.amarelo.TabIndex = 0
        Me.amarelo.Text = "Amarelo"
        '
        'lblverde
        '
        Me.lblverde.AutoSize = True
        Me.lblverde.BackColor = System.Drawing.Color.Transparent
        Me.lblverde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblverde.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblverde.Location = New System.Drawing.Point(363, 215)
        Me.lblverde.Name = "lblverde"
        Me.lblverde.Size = New System.Drawing.Size(57, 20)
        Me.lblverde.TabIndex = 1
        Me.lblverde.Text = "Verde"
        '
        'lblazul
        '
        Me.lblazul.AutoSize = True
        Me.lblazul.BackColor = System.Drawing.Color.Transparent
        Me.lblazul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblazul.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblazul.Location = New System.Drawing.Point(363, 286)
        Me.lblazul.Name = "lblazul"
        Me.lblazul.Size = New System.Drawing.Size(44, 20)
        Me.lblazul.TabIndex = 2
        Me.lblazul.Text = "Azul"
        '
        'lblvermelho
        '
        Me.lblvermelho.AutoSize = True
        Me.lblvermelho.BackColor = System.Drawing.Color.Transparent
        Me.lblvermelho.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvermelho.ForeColor = System.Drawing.Color.Red
        Me.lblvermelho.Location = New System.Drawing.Point(363, 252)
        Me.lblvermelho.Name = "lblvermelho"
        Me.lblvermelho.Size = New System.Drawing.Size(85, 20)
        Me.lblvermelho.TabIndex = 3
        Me.lblvermelho.Text = "Vermelho"
        '
        'lblpreto
        '
        Me.lblpreto.AutoSize = True
        Me.lblpreto.BackColor = System.Drawing.Color.Transparent
        Me.lblpreto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpreto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblpreto.Location = New System.Drawing.Point(363, 320)
        Me.lblpreto.Name = "lblpreto"
        Me.lblpreto.Size = New System.Drawing.Size(52, 20)
        Me.lblpreto.TabIndex = 4
        Me.lblpreto.Text = "Preto"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbltitle.Location = New System.Drawing.Point(204, 229)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(43, 20)
        Me.lbltitle.TabIndex = 5
        Me.lbltitle.Text = "Title"
        '
        'frmTelaInicial
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.lblpreto)
        Me.Controls.Add(Me.lblvermelho)
        Me.Controls.Add(Me.lblazul)
        Me.Controls.Add(Me.lblverde)
        Me.Controls.Add(Me.amarelo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTelaInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tela Inicial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents amarelo As Label
    Friend WithEvents lblverde As Label
    Friend WithEvents lblazul As Label
    Friend WithEvents lblvermelho As Label
    Friend WithEvents lblpreto As Label
    Private WithEvents lbltitle As Label
End Class
