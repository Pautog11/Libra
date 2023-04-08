<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TransacBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet5 = New libra2.Database1DataSet5()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TransacTableAdapter = New libra2.Database1DataSet5TableAdapters.transacTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Database1DataSet6 = New libra2.Database1DataSet6()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksTableAdapter = New libra2.Database1DataSet6TableAdapters.booksTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TittleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailabilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransacBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(483, 362)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 41)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.TittleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.AvailabilityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BooksBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(36, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(739, 273)
        Me.DataGridView1.TabIndex = 21
        '
        'TransacBindingSource
        '
        Me.TransacBindingSource.DataMember = "transac"
        Me.TransacBindingSource.DataSource = Me.Database1DataSet5
        '
        'Database1DataSet5
        '
        Me.Database1DataSet5.DataSetName = "Database1DataSet5"
        Me.Database1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 30)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Rented Books"
        '
        'TransacTableAdapter
        '
        Me.TransacTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(611, 362)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 41)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Database1DataSet6
        '
        Me.Database1DataSet6.DataSetName = "Database1DataSet6"
        Me.Database1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "books"
        Me.BooksBindingSource.DataSource = Me.Database1DataSet6
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TittleDataGridViewTextBoxColumn
        '
        Me.TittleDataGridViewTextBoxColumn.DataPropertyName = "Tittle"
        Me.TittleDataGridViewTextBoxColumn.HeaderText = "Tittle"
        Me.TittleDataGridViewTextBoxColumn.Name = "TittleDataGridViewTextBoxColumn"
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        '
        'AvailabilityDataGridViewTextBoxColumn
        '
        Me.AvailabilityDataGridViewTextBoxColumn.DataPropertyName = "Availability"
        Me.AvailabilityDataGridViewTextBoxColumn.HeaderText = "Availability"
        Me.AvailabilityDataGridViewTextBoxColumn.Name = "AvailabilityDataGridViewTextBoxColumn"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransacBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Database1DataSet5 As Database1DataSet5
    Friend WithEvents TransacBindingSource As BindingSource
    Friend WithEvents TransacTableAdapter As Database1DataSet5TableAdapters.transacTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents Database1DataSet6 As Database1DataSet6
    Friend WithEvents BooksBindingSource As BindingSource
    Friend WithEvents BooksTableAdapter As Database1DataSet6TableAdapters.booksTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TittleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AvailabilityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
