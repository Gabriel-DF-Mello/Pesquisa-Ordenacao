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
            this.labelOrdenar = new System.Windows.Forms.Label();
            this.checkBoxRadix = new System.Windows.Forms.CheckBox();
            this.checkBoxQuick = new System.Windows.Forms.CheckBox();
            this.checkBoxBucket = new System.Windows.Forms.CheckBox();
            this.checkBoxHeap = new System.Windows.Forms.CheckBox();
            this.checkBoxMerge = new System.Windows.Forms.CheckBox();
            this.panelFile = new System.Windows.Forms.Panel();
            this.labelCurrentFile = new System.Windows.Forms.Label();
            this.listResults = new System.Windows.Forms.TextBox();
            this.panelPesquisa = new System.Windows.Forms.Panel();
            this.checkBoxSequentialOrdered = new System.Windows.Forms.CheckBox();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.checkBoxBinarySearch = new System.Windows.Forms.CheckBox();
            this.checkBoxSequentialSearch = new System.Windows.Forms.CheckBox();
            this.labelPesquisar = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.labelErrorPesquisar = new System.Windows.Forms.Label();
            this.labelErrorOrdenar = new System.Windows.Forms.Label();
            this.panelSorting.SuspendLayout();
            this.panelFile.SuspendLayout();
            this.panelPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(13, 37);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnNewFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.labelFile.Location = new System.Drawing.Point(13, 14);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(63, 17);
            this.labelFile.TabIndex = 2;
            this.labelFile.Text = "Arquivos";
            // 
            // checkBoxSelection
            // 
            this.checkBoxSelection.AutoSize = true;
            this.checkBoxSelection.Enabled = false;
            this.checkBoxSelection.Location = new System.Drawing.Point(13, 40);
            this.checkBoxSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxSelection.Name = "checkBoxSelection";
            this.checkBoxSelection.Size = new System.Drawing.Size(118, 21);
            this.checkBoxSelection.TabIndex = 3;
            this.checkBoxSelection.Text = "Selection Sort";
            this.checkBoxSelection.UseVisualStyleBackColor = true;
            // 
            // checkBoxInsertion
            // 
            this.checkBoxInsertion.AutoSize = true;
            this.checkBoxInsertion.Enabled = false;
            this.checkBoxInsertion.Location = new System.Drawing.Point(13, 67);
            this.checkBoxInsertion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxInsertion.Name = "checkBoxInsertion";
            this.checkBoxInsertion.Size = new System.Drawing.Size(114, 21);
            this.checkBoxInsertion.TabIndex = 4;
            this.checkBoxInsertion.Text = "Insertion Sort";
            this.checkBoxInsertion.UseVisualStyleBackColor = true;
            // 
            // checkBoxBubble
            // 
            this.checkBoxBubble.AutoSize = true;
            this.checkBoxBubble.Enabled = false;
            this.checkBoxBubble.Location = new System.Drawing.Point(13, 94);
            this.checkBoxBubble.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxBubble.Name = "checkBoxBubble";
            this.checkBoxBubble.Size = new System.Drawing.Size(104, 21);
            this.checkBoxBubble.TabIndex = 5;
            this.checkBoxBubble.Text = "Bubble Sort";
            this.checkBoxBubble.UseVisualStyleBackColor = true;
            // 
            // checkBoxCocktail
            // 
            this.checkBoxCocktail.AutoSize = true;
            this.checkBoxCocktail.Enabled = false;
            this.checkBoxCocktail.Location = new System.Drawing.Point(13, 124);
            this.checkBoxCocktail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxCocktail.Name = "checkBoxCocktail";
            this.checkBoxCocktail.Size = new System.Drawing.Size(109, 21);
            this.checkBoxCocktail.TabIndex = 6;
            this.checkBoxCocktail.Text = "Cocktail Sort";
            this.checkBoxCocktail.UseVisualStyleBackColor = true;
            // 
            // checkBoxComb
            // 
            this.checkBoxComb.AutoSize = true;
            this.checkBoxComb.Enabled = false;
            this.checkBoxComb.Location = new System.Drawing.Point(13, 151);
            this.checkBoxComb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxComb.Name = "checkBoxComb";
            this.checkBoxComb.Size = new System.Drawing.Size(96, 21);
            this.checkBoxComb.TabIndex = 7;
            this.checkBoxComb.Text = "Comb Sort";
            this.checkBoxComb.UseVisualStyleBackColor = true;
            // 
            // checkBoxShell
            // 
            this.checkBoxShell.AutoSize = true;
            this.checkBoxShell.Enabled = false;
            this.checkBoxShell.Location = new System.Drawing.Point(13, 179);
            this.checkBoxShell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxShell.Name = "checkBoxShell";
            this.checkBoxShell.Size = new System.Drawing.Size(91, 21);
            this.checkBoxShell.TabIndex = 8;
            this.checkBoxShell.Text = "Shell Sort";
            this.checkBoxShell.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(16, 458);
            this.btnRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(229, 23);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Confirmar";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // panelSorting
            // 
            this.panelSorting.Controls.Add(this.labelOrdenar);
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
            this.panelSorting.Location = new System.Drawing.Point(16, 110);
            this.panelSorting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSorting.Name = "panelSorting";
            this.panelSorting.Size = new System.Drawing.Size(229, 344);
            this.panelSorting.TabIndex = 10;
            // 
            // labelOrdenar
            // 
            this.labelOrdenar.AutoSize = true;
            this.labelOrdenar.Location = new System.Drawing.Point(10, 10);
            this.labelOrdenar.Name = "labelOrdenar";
            this.labelOrdenar.Size = new System.Drawing.Size(61, 17);
            this.labelOrdenar.TabIndex = 4;
            this.labelOrdenar.Text = "Ordenar";
            // 
            // checkBoxRadix
            // 
            this.checkBoxRadix.AutoSize = true;
            this.checkBoxRadix.Enabled = false;
            this.checkBoxRadix.Location = new System.Drawing.Point(13, 315);
            this.checkBoxRadix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxRadix.Name = "checkBoxRadix";
            this.checkBoxRadix.Size = new System.Drawing.Size(95, 21);
            this.checkBoxRadix.TabIndex = 13;
            this.checkBoxRadix.Text = "Radix Sort";
            this.checkBoxRadix.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuick
            // 
            this.checkBoxQuick.AutoSize = true;
            this.checkBoxQuick.Enabled = false;
            this.checkBoxQuick.Location = new System.Drawing.Point(13, 232);
            this.checkBoxQuick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxQuick.Name = "checkBoxQuick";
            this.checkBoxQuick.Size = new System.Drawing.Size(96, 21);
            this.checkBoxQuick.TabIndex = 10;
            this.checkBoxQuick.Text = "Quick Sort";
            this.checkBoxQuick.UseVisualStyleBackColor = true;
            // 
            // checkBoxBucket
            // 
            this.checkBoxBucket.AutoSize = true;
            this.checkBoxBucket.Enabled = false;
            this.checkBoxBucket.Location = new System.Drawing.Point(13, 288);
            this.checkBoxBucket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxBucket.Name = "checkBoxBucket";
            this.checkBoxBucket.Size = new System.Drawing.Size(103, 21);
            this.checkBoxBucket.TabIndex = 12;
            this.checkBoxBucket.Text = "Bucket Sort";
            this.checkBoxBucket.UseVisualStyleBackColor = true;
            // 
            // checkBoxHeap
            // 
            this.checkBoxHeap.AutoSize = true;
            this.checkBoxHeap.Enabled = false;
            this.checkBoxHeap.Location = new System.Drawing.Point(13, 259);
            this.checkBoxHeap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxHeap.Name = "checkBoxHeap";
            this.checkBoxHeap.Size = new System.Drawing.Size(94, 21);
            this.checkBoxHeap.TabIndex = 11;
            this.checkBoxHeap.Text = "Heap Sort";
            this.checkBoxHeap.UseVisualStyleBackColor = true;
            // 
            // checkBoxMerge
            // 
            this.checkBoxMerge.AutoSize = true;
            this.checkBoxMerge.Enabled = false;
            this.checkBoxMerge.Location = new System.Drawing.Point(13, 206);
            this.checkBoxMerge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxMerge.Name = "checkBoxMerge";
            this.checkBoxMerge.Size = new System.Drawing.Size(100, 21);
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
            this.panelFile.Location = new System.Drawing.Point(16, 12);
            this.panelFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFile.Name = "panelFile";
            this.panelFile.Size = new System.Drawing.Size(229, 94);
            this.panelFile.TabIndex = 11;
            // 
            // labelCurrentFile
            // 
            this.labelCurrentFile.AutoSize = true;
            this.labelCurrentFile.Location = new System.Drawing.Point(13, 63);
            this.labelCurrentFile.Name = "labelCurrentFile";
            this.labelCurrentFile.Size = new System.Drawing.Size(47, 17);
            this.labelCurrentFile.TabIndex = 3;
            this.labelCurrentFile.Text = "Qnt: 0";
            // 
            // listResults
            // 
            this.listResults.BackColor = System.Drawing.SystemColors.InfoText;
            this.listResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResults.ForeColor = System.Drawing.SystemColors.Window;
            this.listResults.Location = new System.Drawing.Point(265, 12);
            this.listResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listResults.Multiline = true;
            this.listResults.Name = "listResults";
            this.listResults.ReadOnly = true;
            this.listResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listResults.Size = new System.Drawing.Size(409, 566);
            this.listResults.TabIndex = 12;
            this.listResults.Text = "...";
            // 
            // panelPesquisa
            // 
            this.panelPesquisa.Controls.Add(this.checkBoxSequentialOrdered);
            this.panelPesquisa.Controls.Add(this.textBoxPesquisa);
            this.panelPesquisa.Controls.Add(this.checkBoxBinarySearch);
            this.panelPesquisa.Controls.Add(this.checkBoxSequentialSearch);
            this.panelPesquisa.Controls.Add(this.labelPesquisar);
            this.panelPesquisa.Location = new System.Drawing.Point(689, 12);
            this.panelPesquisa.Name = "panelPesquisa";
            this.panelPesquisa.Size = new System.Drawing.Size(263, 154);
            this.panelPesquisa.TabIndex = 13;
            // 
            // checkBoxSequentialOrdered
            // 
            this.checkBoxSequentialOrdered.AutoSize = true;
            this.checkBoxSequentialOrdered.Enabled = false;
            this.checkBoxSequentialOrdered.Location = new System.Drawing.Point(18, 97);
            this.checkBoxSequentialOrdered.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxSequentialOrdered.Name = "checkBoxSequentialOrdered";
            this.checkBoxSequentialOrdered.Size = new System.Drawing.Size(178, 21);
            this.checkBoxSequentialOrdered.TabIndex = 16;
            this.checkBoxSequentialOrdered.Text = "Sequencial (Ordenado)";
            this.checkBoxSequentialOrdered.UseVisualStyleBackColor = true;
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(18, 37);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(225, 22);
            this.textBoxPesquisa.TabIndex = 15;
            // 
            // checkBoxBinarySearch
            // 
            this.checkBoxBinarySearch.AutoSize = true;
            this.checkBoxBinarySearch.Enabled = false;
            this.checkBoxBinarySearch.Location = new System.Drawing.Point(18, 122);
            this.checkBoxBinarySearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxBinarySearch.Name = "checkBoxBinarySearch";
            this.checkBoxBinarySearch.Size = new System.Drawing.Size(74, 21);
            this.checkBoxBinarySearch.TabIndex = 14;
            this.checkBoxBinarySearch.Text = "Binária";
            this.checkBoxBinarySearch.UseVisualStyleBackColor = true;
            // 
            // checkBoxSequentialSearch
            // 
            this.checkBoxSequentialSearch.AutoSize = true;
            this.checkBoxSequentialSearch.Enabled = false;
            this.checkBoxSequentialSearch.Location = new System.Drawing.Point(18, 73);
            this.checkBoxSequentialSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxSequentialSearch.Name = "checkBoxSequentialSearch";
            this.checkBoxSequentialSearch.Size = new System.Drawing.Size(200, 21);
            this.checkBoxSequentialSearch.TabIndex = 14;
            this.checkBoxSequentialSearch.Text = "Sequencial (Desordenado)";
            this.checkBoxSequentialSearch.UseVisualStyleBackColor = true;
            // 
            // labelPesquisar
            // 
            this.labelPesquisar.AutoSize = true;
            this.labelPesquisar.Location = new System.Drawing.Point(15, 14);
            this.labelPesquisar.Name = "labelPesquisar";
            this.labelPesquisar.Size = new System.Drawing.Size(71, 17);
            this.labelPesquisar.TabIndex = 14;
            this.labelPesquisar.Text = "Pesquisar";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(689, 171);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(263, 23);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Confirmar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // labelErrorPesquisar
            // 
            this.labelErrorPesquisar.AutoSize = true;
            this.labelErrorPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorPesquisar.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPesquisar.Location = new System.Drawing.Point(689, 177);
            this.labelErrorPesquisar.Name = "labelErrorPesquisar";
            this.labelErrorPesquisar.Size = new System.Drawing.Size(0, 17);
            this.labelErrorPesquisar.TabIndex = 15;
            // 
            // labelErrorOrdenar
            // 
            this.labelErrorOrdenar.AutoSize = true;
            this.labelErrorOrdenar.Location = new System.Drawing.Point(16, 487);
            this.labelErrorOrdenar.Name = "labelErrorOrdenar";
            this.labelErrorOrdenar.Size = new System.Drawing.Size(0, 17);
            this.labelErrorOrdenar.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 590);
            this.Controls.Add(this.labelErrorOrdenar);
            this.Controls.Add(this.labelErrorPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.panelPesquisa);
            this.Controls.Add(this.listResults);
            this.Controls.Add(this.panelFile);
            this.Controls.Add(this.panelSorting);
            this.Controls.Add(this.btnRun);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSorting.ResumeLayout(false);
            this.panelSorting.PerformLayout();
            this.panelFile.ResumeLayout(false);
            this.panelFile.PerformLayout();
            this.panelPesquisa.ResumeLayout(false);
            this.panelPesquisa.PerformLayout();
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
        private System.Windows.Forms.TextBox listResults;
        private System.Windows.Forms.CheckBox checkBoxMerge;
        private System.Windows.Forms.CheckBox checkBoxRadix;
        private System.Windows.Forms.CheckBox checkBoxQuick;
        private System.Windows.Forms.CheckBox checkBoxBucket;
        private System.Windows.Forms.CheckBox checkBoxHeap;
        private System.Windows.Forms.Label labelOrdenar;
        private System.Windows.Forms.Panel panelPesquisa;
        private System.Windows.Forms.Label labelPesquisar;
        private System.Windows.Forms.CheckBox checkBoxBinarySearch;
        private System.Windows.Forms.CheckBox checkBoxSequentialSearch;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Label labelErrorPesquisar;
        private System.Windows.Forms.Label labelErrorOrdenar;
        private System.Windows.Forms.CheckBox checkBoxSequentialOrdered;
    }
}

