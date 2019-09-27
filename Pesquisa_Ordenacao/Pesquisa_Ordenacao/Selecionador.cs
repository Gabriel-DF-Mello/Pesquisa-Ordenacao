using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesquisa_Ordenacao
{
    static class Selecionador
    {
        static int mergeQtdCmp = 0;
        static int mergeQtdTrc = 0;
        public static string SelectionSort(int[] v)
        {
            var relogio = new System.Diagnostics.Stopwatch();
            int pos_menor;
            int aux;
            int qtdCmp = 0, qtdTrc = 0;
            int n = v.Length;

            relogio.Start();
            for(int i = 0; i < n - 1; i += 1)
            {
                pos_menor = i;
                for (int j = (i + 1); j < n; j += 1)
                {
                    qtdCmp += 1;
                    if(v[j] < v[pos_menor])
                    {
                        pos_menor = j;
                    }
                }

                if(pos_menor != i)
                {
                    aux = v[i];
                    v[i] = v[pos_menor];
                    v[pos_menor] = aux;
                    qtdTrc += 1;
                }
            }
            relogio.Stop();
            string message = Environment.NewLine + "Selection Sort: " + Environment.NewLine + "Tempo passado: " + relogio.Elapsed + " " + Environment.NewLine + "Quantidade de comparações: " + qtdCmp + " " + Environment.NewLine + "Quantidade de trocas: " + qtdTrc + " " + Environment.NewLine;
            return message;
        }

        public static string InsertionSort(int[] v)
        {
            var relogio = new System.Diagnostics.Stopwatch();
            int aux;
            int qtdCmp = 1, qtdTrc = 0;
            int i, j;
            int n = v.Length;

            relogio.Start();
            for (i = 1; i < n; i += 1)
            {
                aux = v[i];
                for (j = (i - 1); (j >= 0) && (aux < v[j]) ; j -= 1, qtdCmp += 1)
                {
                    v[j+1] = v[j];
                    qtdTrc += 1;
                }
                v[j + 1] = aux;
                qtdTrc += 1;
            }
            relogio.Stop();
            string message = Environment.NewLine + "Insertion Sort: " + Environment.NewLine + "Tempo passado: " + relogio.Elapsed + " " + Environment.NewLine + "Quantidade de comparações: " + qtdCmp + " " + Environment.NewLine + "Quantidade de trocas: " + qtdTrc + " " + Environment.NewLine; return message;
        }

        public static string BubbleSort(int[] v)
        {
            var relogio = new System.Diagnostics.Stopwatch();
            int n = v.Length;
            int aux;
            bool trocado = false;
            int qtdCmp = 0, qtdTrc = 0;

            relogio.Start();
            do
            {
                trocado = false;
                for (int i = 0; i < n - 1; i += 1)
                {
                    qtdCmp += 1;

                    if (v[i] > v[i + 1])
                    {
                        qtdTrc += 1;
                        aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        trocado = true;
                    }
                }
                n -= 1;
            } while (trocado);

            relogio.Stop();
            string message = Environment.NewLine + "Bubble Sort: " + Environment.NewLine + "Tempo passado: " + relogio.Elapsed + " " + Environment.NewLine + "Quantidade de comparações: " + qtdCmp + " " + Environment.NewLine + "Quantidade de trocas: " + qtdTrc + " " + Environment.NewLine;
            return message;
        }



        public static string CocktailSort(int[] v)
        {
            var relogio = new System.Diagnostics.Stopwatch();
            int stt = 0, end = v.Length;
            int aux;
            bool trocado = false;
            int qtdCmp = 0, qtdTrc = 0;
            string message;

            relogio.Start();
            do
            {
                trocado = false;
                for (int i = stt; i < end - 1; i += 1)
                {
                    qtdCmp += 1;

                    if (v[i] > v[i + 1])
                    {
                        qtdTrc += 1;
                        aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        trocado = true;
                    }
                }
                end -= 1;

                if (!trocado)
                {
                    relogio.Stop();
                    message = Environment.NewLine + "Cocktail Sort: " + Environment.NewLine + "Tempo passado: " + relogio.Elapsed + " " + Environment.NewLine + "Quantidade de comparações: " + qtdCmp + " " + Environment.NewLine + "Quantidade de trocas: " + qtdTrc + " " + Environment.NewLine;
                    return message;
                }

                for (int i = end; i > stt; i -= 1)
                {
                    qtdCmp += 1;

                    if (v[i] < v[i - 1])
                    {
                        qtdTrc += 1;
                        aux = v[i];
                        v[i] = v[i - 1];
                        v[i - 1] = aux;
                        trocado = true;
                    }
                }
                stt += 1;
            } while ((trocado)&&(stt<=end));

            relogio.Stop();
            message = Environment.NewLine + "Cocktail Sort: " + Environment.NewLine + "Tempo passado: " + relogio.Elapsed + " " + Environment.NewLine + "Quantidade de comparações: " + qtdCmp + " " + Environment.NewLine + "Quantidade de trocas: " + qtdTrc + " " + Environment.NewLine;
            return message;
        }

        public static string CombSort(int[] v)
        {
            var relogio = new System.Diagnostics.Stopwatch();
            int distancia = (int) (v.Length / 1.3);
            int aux;
            bool trocado = false;
            int qtdCmp = 0, qtdTrc = 0;

            relogio.Start();
            do
            {
                distancia = (int) (distancia / 1.3);
                if (distancia < 1) distancia = 1;

                trocado = false;
                for (int i = 0; i + distancia < v.Length; i++)
                {
                    qtdCmp+=1;
                    if (v[i] > v[i + distancia])
                    {
                        aux = v[i];
                        v[i] = v[i + distancia];
                        v[i + distancia] = aux;
                        trocado = true;
                        qtdTrc+=1;
                    }
                }
            } while (distancia != 1 || trocado);
            relogio.Stop();
            string message = Environment.NewLine + "Comb Sort: " + Environment.NewLine + "Tempo passado: " + relogio.Elapsed + " " + Environment.NewLine + "Quantidade de comparações: " + qtdCmp + " " + Environment.NewLine + "Quantidade de trocas: " + qtdTrc + " " + Environment.NewLine;
            return message;
        }
        public static string ShellSort(int[] v)
        {
            var relogio = new System.Diagnostics.Stopwatch();
            int dist = 1;
            int aux, i, j;
            int qtdCmp = 0, qtdTrc = 0;

            relogio.Start();
            do
            {
                dist = 3 * dist + 1; 
            } while (dist < v.Length);

            do
            {
                dist /= 3;
                for (i = dist; i < v.Length; i++)
                {
                    aux = v[i];
                    qtdCmp++;
                    for (j = i - dist; j >= 0 && aux < v[j]; j = j - dist, qtdCmp++)
                    {
                        v[j + dist] = v[j];
                        qtdTrc++;
                    }
                    v[j + dist] = aux;
                    qtdTrc++;
                }
            } while (dist > 1);

            relogio.Stop();
            string message = Environment.NewLine + "Shell Sort: " + Environment.NewLine + "Tempo passado: " + relogio.Elapsed + " " + Environment.NewLine + "Quantidade de comparações: " + qtdCmp + " " + Environment.NewLine + "Quantidade de trocas: " + qtdTrc + " " + Environment.NewLine;
            return message;
        }

        public static string DisplayMergeSort(int[] v, int stt, int end)
        {
            var relogio = new System.Diagnostics.Stopwatch();
            relogio.Start();
            MergeSort(v, stt, end);
            relogio.Stop();
            string message = Environment.NewLine + "Merge Sort: " + Environment.NewLine + "Tempo passado: " + relogio.Elapsed + " " + Environment.NewLine + "Quantidade de comparações: " + mergeQtdCmp + " " + Environment.NewLine + "Quantidade de trocas: " + mergeQtdTrc + " " + Environment.NewLine;
            mergeQtdTrc = 0;
            mergeQtdCmp = 0;
            return message;
        }

        public static void MergeSort(int[] v, int stt, int end)
        {
            if (stt < end)
            {
                int mid = (stt + end) / 2;
                //Console.WriteLine("stt: " + stt + "\nmid: " + mid + "\nend: " + end + "\n\n");
                if(mid > stt) MergeSort(v, stt, mid);
                if(end > mid) MergeSort(v, mid + 1, end);
                Merge(v, stt, mid, end);//Ponto de retorno, inicio da ordenação
            }
        }

        public static void Merge(int[] v, int stt, int mid, int end)
        {
            int i = stt;
            int j = mid + 1;
            int k = 0;
            int size = (end - stt) + 1;

            int[] aux = new int[size];

            while((i <= mid) && (j <= end)){
                mergeQtdCmp += 1;
                if(v[i] < v[j])
                {
                    mergeQtdTrc += 1;
                    aux[k] = v[i];
                    i += 1;
                }
                else
                {
                    mergeQtdTrc += 1;
                    aux[k] = v[j];
                    j += 1;
                }
                k += 1;
            }

            while(i <= mid)
            {
                mergeQtdTrc += 1;
                aux[k] = v[i];
                i += 1;
                k += 1;
            }

            while (j <= end)
            {
                mergeQtdTrc += 1;
                aux[k] = v[j];
                j += 1;
                k += 1;
            }

            for(int p = stt; p <= end; p++)
            {
                v[p] = aux[p - stt];
            }
            aux = null;
        }

        public static string HeapSort(int[] v)
        {
            var relogio = new System.Diagnostics.Stopwatch();
            int aux;
            int i;
            int qtdCmp = 0, qtdTrc = 0;
            int n = v.Length - 1;
            relogio.Start();

            while (n > 1)
            {
                for (i = n / 2; i > 0; i -= 1)
                {
                    Console.WriteLine(i);
                    qtdCmp++;
                    if (v[i] < v[i * 2])
                    {
                        aux = v[i];
                        v[i] = v[i * 2];
                        v[i * 2] = aux;
                        qtdTrc++;
                    }

                    if (i * 2 + 1 <= n)
                    {
                        qtdCmp++;
                        if (v[i] < v[i * 2 + 1])
                        {
                            aux = v[i];
                            v[i] = v[i * 2 + 1];
                            v[i * 2 + 1] = aux;
                            qtdTrc++;
                        }
                    }
                }
                aux = v[1];
                v[1] = v[n];
                v[n] = aux;
                qtdTrc++;

                n--;
            }

            relogio.Stop();
            string message = Environment.NewLine + "Heap Sort: " + Environment.NewLine + "Tempo passado: " + relogio.Elapsed + " " + Environment.NewLine + "Quantidade de comparações: " + mergeQtdCmp + " " + Environment.NewLine + "Quantidade de trocas: " + mergeQtdTrc + " " + Environment.NewLine;
            return message;
        }
    }
}
