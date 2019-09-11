using System;
using System.Collections;

namespace Pesquisa_Ordenacao
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.checkBoxSelection = new System.Windows.Forms.CheckBox();
            this.checkBoxInsertion = new System.Windows.Forms.CheckBox();
            this.checkBoxBubble = new System.Windows.Forms.CheckBox();
            this.checkBoxCocktail = new System.Windows.Forms.CheckBox();
            this.checkBoxComb = new System.Windows.Forms.CheckBox();
            this.checkBoxShell = new System.Windows.Forms.CheckBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.panelSorting = new System.Windows.Forms.Panel();
            this.panelFile = new System.Windows.Forms.Panel();
            this.labelCurrentFile = new System.Windows.Forms.Label();
            this.listResults = new System.Windows.Forms.TextBox();
            this.panelSorting.SuspendLayout();
            this.panelFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(14, 37);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(97, 23);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Selecionar";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnNewFile
            // 
            this.btnNewFile.Location = new System.Drawing.Point(117, 37);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(75, 23);
            this.btnNewFile.TabIndex = 1;
            this.btnNewFile.Text = "Novo";
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(14, 14);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(63, 17);
            this.labelFile.TabIndex = 2;
            this.labelFile.Text = "Arquivos";
            // 
            // checkBoxSelection
            // 
            this.checkBoxSelection.AutoSize = true;
            this.checkBoxSelection.Location = new System.Drawing.Point(14, 12);
            this.checkBoxSelection.Name = "checkBoxSelection";
            this.checkBoxSelection.Size = new System.Drawing.Size(118, 21);
            this.checkBoxSelection.TabIndex = 3;
            this.checkBoxSelection.Text = "Selection Sort";
            this.checkBoxSelection.UseVisualStyleBackColor = true;
            // 
            // checkBoxInsertion
            // 
            this.checkBoxInsertion.AutoSize = true;
            this.checkBoxInsertion.Location = new System.Drawing.Point(14, 39);
            this.checkBoxInsertion.Name = "checkBoxInsertion";
            this.checkBoxInsertion.Size = new System.Drawing.Size(114, 21);
            this.checkBoxInsertion.TabIndex = 4;
            this.checkBoxInsertion.Text = "Insertion Sort";
            this.checkBoxInsertion.UseVisualStyleBackColor = true;
            // 
            // checkBoxBubble
            // 
            this.checkBoxBubble.AutoSize = true;
            this.checkBoxBubble.Location = new System.Drawing.Point(14, 67);
            this.checkBoxBubble.Name = "checkBoxBubble";
            this.checkBoxBubble.Size = new System.Drawing.Size(104, 21);
            this.checkBoxBubble.TabIndex = 5;
            this.checkBoxBubble.Text = "Bubble Sort";
            this.checkBoxBubble.UseVisualStyleBackColor = true;
            // 
            // checkBoxCocktail
            // 
            this.checkBoxCocktail.AutoSize = true;
            this.checkBoxCocktail.Location = new System.Drawing.Point(14, 96);
            this.checkBoxCocktail.Name = "checkBoxCocktail";
            this.checkBoxCocktail.Size = new System.Drawing.Size(109, 21);
            this.checkBoxCocktail.TabIndex = 6;
            this.checkBoxCocktail.Text = "Cocktail Sort";
            this.checkBoxCocktail.UseVisualStyleBackColor = true;
            // 
            // checkBoxComb
            // 
            this.checkBoxComb.AutoSize = true;
            this.checkBoxComb.Location = new System.Drawing.Point(14, 123);
            this.checkBoxComb.Name = "checkBoxComb";
            this.checkBoxComb.Size = new System.Drawing.Size(96, 21);
            this.checkBoxComb.TabIndex = 7;
            this.checkBoxComb.Text = "Comb Sort";
            this.checkBoxComb.UseVisualStyleBackColor = true;
            // 
            // checkBoxShell
            // 
            this.checkBoxShell.AutoSize = true;
            this.checkBoxShell.Location = new System.Drawing.Point(14, 151);
            this.checkBoxShell.Name = "checkBoxShell";
            this.checkBoxShell.Size = new System.Drawing.Size(91, 21);
            this.checkBoxShell.TabIndex = 8;
            this.checkBoxShell.Text = "Shell Sort";
            this.checkBoxShell.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(16, 297);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(229, 23);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Confirmar";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // panelSorting
            // 
            this.panelSorting.Controls.Add(this.checkBoxCocktail);
            this.panelSorting.Controls.Add(this.checkBoxSelection);
            this.panelSorting.Controls.Add(this.checkBoxShell);
            this.panelSorting.Controls.Add(this.checkBoxInsertion);
            this.panelSorting.Controls.Add(this.checkBoxComb);
            this.panelSorting.Controls.Add(this.checkBoxBubble);
            this.panelSorting.Location = new System.Drawing.Point(16, 111);
            this.panelSorting.Name = "panelSorting";
            this.panelSorting.Size = new System.Drawing.Size(229, 180);
            this.panelSorting.TabIndex = 10;
            // 
            // panelFile
            // 
            this.panelFile.Controls.Add(this.labelCurrentFile);
            this.panelFile.Controls.Add(this.btnNewFile);
            this.panelFile.Controls.Add(this.btnSelectFile);
            this.panelFile.Controls.Add(this.labelFile);
            this.panelFile.Location = new System.Drawing.Point(16, 12);
            this.panelFile.Name = "panelFile";
            this.panelFile.Size = new System.Drawing.Size(229, 93);
            this.panelFile.TabIndex = 11;
            // 
            // labelCurrentFile
            // 
            this.labelCurrentFile.AutoSize = true;
            this.labelCurrentFile.Location = new System.Drawing.Point(14, 63);
            this.labelCurrentFile.Name = "labelCurrentFile";
            this.labelCurrentFile.Size = new System.Drawing.Size(47, 17);
            this.labelCurrentFile.TabIndex = 3;
            this.labelCurrentFile.Text = "Qnt: 0";
            // 
            // listResults
            // 
            this.listResults.BackColor = System.Drawing.SystemColors.InfoText;
            this.listResults.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResults.ForeColor = System.Drawing.SystemColors.Window;
            this.listResults.Location = new System.Drawing.Point(265, 12);
            this.listResults.Multiline = true;
            this.listResults.Name = "listResults";
            this.listResults.ReadOnly = true;
            this.listResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listResults.Size = new System.Drawing.Size(409, 308);
            this.listResults.TabIndex = 12;
            this.listResults.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 336);
            this.Controls.Add(this.listResults);
            this.Controls.Add(this.panelFile);
            this.Controls.Add(this.panelSorting);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSorting.ResumeLayout(false);
            this.panelSorting.PerformLayout();
            this.panelFile.ResumeLayout(false);
            this.panelFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.CheckBox checkBoxSelection;
        private System.Windows.Forms.CheckBox checkBoxInsertion;
        private System.Windows.Forms.CheckBox checkBoxBubble;
        private System.Windows.Forms.CheckBox checkBoxCocktail;
        private System.Windows.Forms.CheckBox checkBoxComb;
        private System.Windows.Forms.CheckBox checkBoxShell;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Panel panelSorting;
        private System.Windows.Forms.Panel panelFile;
        private System.Windows.Forms.Label labelCurrentFile;
        private ArrayList messages;
        int[] template, v;
        private System.Windows.Forms.TextBox listResults;
    }
}

