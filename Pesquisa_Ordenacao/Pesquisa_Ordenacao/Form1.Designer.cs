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
            this.checkBoxMerge = new System.Windows.Forms.CheckBox();
            this.panelFile = new System.Windows.Forms.Panel();
            this.labelCurrentFile = new System.Windows.Forms.Label();
            this.listResults = new System.Windows.Forms.TextBox();
            this.checkBoxRadix = new System.Windows.Forms.CheckBox();
            this.checkBoxQuick = new System.Windows.Forms.CheckBox();
            this.checkBoxBucket = new System.Windows.Forms.CheckBox();
            this.checkBoxHeap = new System.Windows.Forms.CheckBox();
            this.panelSorting.SuspendLayout();
            this.panelFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(10, 30);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(73, 19);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Selecionar";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnNewFile
            // 
            this.btnNewFile.Location = new System.Drawing.Point(88, 30);
            this.btnNewFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(56, 19);
            this.btnNewFile.TabIndex = 1;
            this.btnNewFile.Text = "Novo";
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(10, 11);
            this.labelFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(48, 13);
            this.labelFile.TabIndex = 2;
            this.labelFile.Text = "Arquivos";
            // 
            // checkBoxSelection
            // 
            this.checkBoxSelection.AutoSize = true;
            this.checkBoxSelection.Location = new System.Drawing.Point(10, 10);
            this.checkBoxSelection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxSelection.Name = "checkBoxSelection";
            this.checkBoxSelection.Size = new System.Drawing.Size(92, 17);
            this.checkBoxSelection.TabIndex = 3;
            this.checkBoxSelection.Text = "Selection Sort";
            this.checkBoxSelection.UseVisualStyleBackColor = true;
            // 
            // checkBoxInsertion
            // 
            this.checkBoxInsertion.AutoSize = true;
            this.checkBoxInsertion.Location = new System.Drawing.Point(10, 32);
            this.checkBoxInsertion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxInsertion.Name = "checkBoxInsertion";
            this.checkBoxInsertion.Size = new System.Drawing.Size(88, 17);
            this.checkBoxInsertion.TabIndex = 4;
            this.checkBoxInsertion.Text = "Insertion Sort";
            this.checkBoxInsertion.UseVisualStyleBackColor = true;
            // 
            // checkBoxBubble
            // 
            this.checkBoxBubble.AutoSize = true;
            this.checkBoxBubble.Location = new System.Drawing.Point(10, 54);
            this.checkBoxBubble.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxBubble.Name = "checkBoxBubble";
            this.checkBoxBubble.Size = new System.Drawing.Size(81, 17);
            this.checkBoxBubble.TabIndex = 5;
            this.checkBoxBubble.Text = "Bubble Sort";
            this.checkBoxBubble.UseVisualStyleBackColor = true;
            // 
            // checkBoxCocktail
            // 
            this.checkBoxCocktail.AutoSize = true;
            this.checkBoxCocktail.Location = new System.Drawing.Point(10, 78);
            this.checkBoxCocktail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxCocktail.Name = "checkBoxCocktail";
            this.checkBoxCocktail.Size = new System.Drawing.Size(86, 17);
            this.checkBoxCocktail.TabIndex = 6;
            this.checkBoxCocktail.Text = "Cocktail Sort";
            this.checkBoxCocktail.UseVisualStyleBackColor = true;
            // 
            // checkBoxComb
            // 
            this.checkBoxComb.AutoSize = true;
            this.checkBoxComb.Location = new System.Drawing.Point(10, 100);
            this.checkBoxComb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxComb.Name = "checkBoxComb";
            this.checkBoxComb.Size = new System.Drawing.Size(75, 17);
            this.checkBoxComb.TabIndex = 7;
            this.checkBoxComb.Text = "Comb Sort";
            this.checkBoxComb.UseVisualStyleBackColor = true;
            // 
            // checkBoxShell
            // 
            this.checkBoxShell.AutoSize = true;
            this.checkBoxShell.Location = new System.Drawing.Point(10, 123);
            this.checkBoxShell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxShell.Name = "checkBoxShell";
            this.checkBoxShell.Size = new System.Drawing.Size(71, 17);
            this.checkBoxShell.TabIndex = 8;
            this.checkBoxShell.Text = "Shell Sort";
            this.checkBoxShell.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(12, 354);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(172, 19);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Confirmar";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // panelSorting
            // 
            this.panelSorting.Controls.Add(this.checkBoxRadix);
            this.panelSorting.Controls.Add(this.checkBoxQuick);
            this.panelSorting.Controls.Add(this.checkBoxBucket);
            this.panelSorting.Controls.Add(this.checkBoxHeap);
            this.panelSorting.Controls.Add(this.checkBoxMerge);
            this.panelSorting.Controls.Add(this.checkBoxCocktail);
            this.panelSorting.Controls.Add(this.checkBoxSelection);
            this.panelSorting.Controls.Add(this.checkBoxShell);
            this.panelSorting.Controls.Add(this.checkBoxInsertion);
            this.panelSorting.Controls.Add(this.checkBoxComb);
            this.panelSorting.Controls.Add(this.checkBoxBubble);
            this.panelSorting.Location = new System.Drawing.Point(12, 90);
            this.panelSorting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSorting.Name = "panelSorting";
            this.panelSorting.Size = new System.Drawing.Size(172, 260);
            this.panelSorting.TabIndex = 10;
            // 
            // checkBoxMerge
            // 
            this.checkBoxMerge.AutoSize = true;
            this.checkBoxMerge.Location = new System.Drawing.Point(10, 145);
            this.checkBoxMerge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxMerge.Name = "checkBoxMerge";
            this.checkBoxMerge.Size = new System.Drawing.Size(78, 17);
            this.checkBoxMerge.TabIndex = 9;
            this.checkBoxMerge.Text = "Merge Sort";
            this.checkBoxMerge.UseVisualStyleBackColor = true;
            // 
            // panelFile
            // 
            this.panelFile.Controls.Add(this.labelCurrentFile);
            this.panelFile.Controls.Add(this.btnNewFile);
            this.panelFile.Controls.Add(this.btnSelectFile);
            this.panelFile.Controls.Add(this.labelFile);
            this.panelFile.Location = new System.Drawing.Point(12, 10);
            this.panelFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFile.Name = "panelFile";
            this.panelFile.Size = new System.Drawing.Size(172, 76);
            this.panelFile.TabIndex = 11;
            // 
            // labelCurrentFile
            // 
            this.labelCurrentFile.AutoSize = true;
            this.labelCurrentFile.Location = new System.Drawing.Point(10, 51);
            this.labelCurrentFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentFile.Name = "labelCurrentFile";
            this.labelCurrentFile.Size = new System.Drawing.Size(36, 13);
            this.labelCurrentFile.TabIndex = 3;
            this.labelCurrentFile.Text = "Qnt: 0";
            // 
            // listResults
            // 
            this.listResults.BackColor = System.Drawing.SystemColors.InfoText;
            this.listResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResults.ForeColor = System.Drawing.SystemColors.Window;
            this.listResults.Location = new System.Drawing.Point(199, 10);
            this.listResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listResults.Multiline = true;
            this.listResults.Name = "listResults";
            this.listResults.ReadOnly = true;
            this.listResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listResults.Size = new System.Drawing.Size(308, 363);
            this.listResults.TabIndex = 12;
            this.listResults.Text = "...";
            // 
            // checkBoxRadix
            // 
            this.checkBoxRadix.AutoSize = true;
            this.checkBoxRadix.Location = new System.Drawing.Point(10, 233);
            this.checkBoxRadix.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRadix.Name = "checkBoxRadix";
            this.checkBoxRadix.Size = new System.Drawing.Size(75, 17);
            this.checkBoxRadix.TabIndex = 13;
            this.checkBoxRadix.Text = "Radix Sort";
            this.checkBoxRadix.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuick
            // 
            this.checkBoxQuick.AutoSize = true;
            this.checkBoxQuick.Location = new System.Drawing.Point(10, 166);
            this.checkBoxQuick.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxQuick.Name = "checkBoxQuick";
            this.checkBoxQuick.Size = new System.Drawing.Size(76, 17);
            this.checkBoxQuick.TabIndex = 10;
            this.checkBoxQuick.Text = "Quick Sort";
            this.checkBoxQuick.UseVisualStyleBackColor = true;
            // 
            // checkBoxBucket
            // 
            this.checkBoxBucket.AutoSize = true;
            this.checkBoxBucket.Location = new System.Drawing.Point(10, 211);
            this.checkBoxBucket.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBucket.Name = "checkBoxBucket";
            this.checkBoxBucket.Size = new System.Drawing.Size(82, 17);
            this.checkBoxBucket.TabIndex = 12;
            this.checkBoxBucket.Text = "Bucket Sort";
            this.checkBoxBucket.UseVisualStyleBackColor = true;
            // 
            // checkBoxHeap
            // 
            this.checkBoxHeap.AutoSize = true;
            this.checkBoxHeap.Location = new System.Drawing.Point(10, 188);
            this.checkBoxHeap.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxHeap.Name = "checkBoxHeap";
            this.checkBoxHeap.Size = new System.Drawing.Size(74, 17);
            this.checkBoxHeap.TabIndex = 11;
            this.checkBoxHeap.Text = "Heap Sort";
            this.checkBoxHeap.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 385);
            this.Controls.Add(this.listResults);
            this.Controls.Add(this.panelFile);
            this.Controls.Add(this.panelSorting);
            this.Controls.Add(this.btnRun);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.CheckBox checkBoxMerge;
        private System.Windows.Forms.CheckBox checkBoxRadix;
        private System.Windows.Forms.CheckBox checkBoxQuick;
        private System.Windows.Forms.CheckBox checkBoxBucket;
        private System.Windows.Forms.CheckBox checkBoxHeap;
    }
}

